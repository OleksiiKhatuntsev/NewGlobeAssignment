# NewGlobeAssignment

# Requirements
1. Installed [.Net Framework 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. Set these environment variables to your OS:
   > BasicDefaultUserName - **Your username for BASIC authentication**  
   > BasicDefaultUserName - **Your password for BASIC authentication**  
   > BasicDefaultUserName - **Your username for Microsoft account**  
   > BasicDefaultUserName - **Your password for Microsoft account**

# Overview
I've created the main scheme of the project, which can be used to create an API and UI test framework for this test application. Here you can see examples of the [UI tests](https://github.com/OleksiiKhatuntsev/NewGlobeAssignment/tree/master/NewGlobeAssignment.Tests/UiTests) and [API tests](https://github.com/OleksiiKhatuntsev/NewGlobeAssignment/tree/master/NewGlobeAssignment.Tests/ApiTests). There is a pretty easy setup process for CI\CD (just install .net and set Env Variables). Also, I don't use confidential information in code, so we are receiving UserCredentials from the Environment (For CI\CD we can use key vaults to store passwords). There is a framework, which we can very easily extend with new tests, and new functional, which is not implemented yet.

I didn't do Unit/Performance testing for this project. Also, I didn't handle the iFrame in Web, but it should be done later.
There is the diagram of the Business Logic Project:
![Type Dependencies Diagram for Common Project](https://github.com/OleksiiKhatuntsev/NewGlobeAssignment/assets/39759290/7d5b8a3b-1102-4600-a32d-5c96202c25eb)


# Projects structure
## Common
There is a project with all logic of the application
### Constants
Folder with all constants, which were used in this app
### Pages
Folder with PageObjects for Selenium
### Facades
Folder with classes, which provides user scenarios for UI testing (using Pages)
### Helpers
Static classes with some converting logic
### Models
All models for data

## Tests
There are 2 folders - with an API tests and with UI
