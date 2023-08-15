using System.Diagnostics;

namespace NewGlobeAssignment.Common.Helpers
{
    internal static class WaitHelpers
    {
        #region Fields

        private static readonly TimeSpan Timeout = TimeSpan.FromSeconds(8);
        private static readonly int StepsNumber = 10;
        private static readonly TimeSpan LowerLimit = TimeSpan.FromMilliseconds(1000);
        private static readonly TimeSpan UpperLimit = TimeSpan.FromMilliseconds(3000);

        #endregion

        #region Public Method

        public static T ForCondition<T>(Func<bool> condition,
                                        Func<T> function,
                                        TimeSpan timeout = default,
                                        string timeoutMessage = "Element is not displayed or enabled")
        {
            if (timeout == default)
            {
                timeout = Timeout;
            }

            var stopwatch = Stopwatch.StartNew();
            var step = CalculateTimeStep(timeout);
            var counter = 0;
            while (stopwatch.Elapsed < timeout)
            {
                counter++;
                try
                {
                    if (condition())
                    {
                        return function != null ? function.Invoke() : default;
                    }
                }
                catch
                {
                    //ignore all exceptions during waiting for condition
                }

                Thread.Sleep(step);
            }

            string errorMessage =
                $"Condition wasn't fulfilled for {timeout.TotalSeconds} seconds, total attempts: {counter}. Message: {timeoutMessage}. Stacktrace: {new StackTrace()}.";

            throw new Exception(errorMessage);
        }

        #endregion

        #region Private Method

        private static TimeSpan CalculateTimeStep(TimeSpan timeout)
        {
            var step = TimeSpan.FromMilliseconds(timeout.TotalMilliseconds / StepsNumber);
            return step < LowerLimit ? LowerLimit : step > UpperLimit ? UpperLimit : step;
        }

        #endregion
    }
}