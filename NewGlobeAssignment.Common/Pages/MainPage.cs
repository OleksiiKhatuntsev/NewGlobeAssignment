﻿using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MainPage : BasePage
    {
        public IEnumerable<IWebElement> Projects() => GetElements(By.XPath("//div[@class='card project-card']"));

        public IWebElement ProjectDescriptionByName(string name) =>
            GetElement(By.XPath($"//*[contains(text(), '{name}')]//ancestor::div[@class = 'card project-card']//span[@class = 'card-description']"));

        public IWebElement ProjectKeyByName(string name) =>
            GetElement(By.XPath($"//*[contains(text(), '{name}')]//ancestor::div[@class = 'card project-card']//div[contains(@class, 'card-field')]//p[@class = 'field-value']"));
    }
}
