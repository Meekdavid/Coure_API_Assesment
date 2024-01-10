# Country Details API

The **Country Details API** is a .NET Core project designed to streamline the retrieval of country details based on phone numbers. It operates by accepting a phone number as a parameter and extracting the country code for further processing. Developed using .NET 6.0, this API ensures efficiency, security, and seamless integration capabilities.
### Key Features

- **Effortless Country Details Retrieval:** Simplify the process of obtaining country details by providing a phone number
- **Country Code Extraction:**  Extracts the country code from the provided phone number, facilitating accurate identification.
- **Country Details Database Integration:** Utilizes an In Memory database system to store and retrieve comprehensive country details based on the extracted country code.
- **Secure Data Handling:** Ensures secure handling of phone number parameters, guarding against potential security threats such as input validation issues
- **Documentation:**  Incorporates Swagger UI endpoints documentation for straightforward accessibility and ease of integration.

## Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Deployment](#deployment)
- [Contributing](#contributing)

## Getting Started

### Prerequisites

Before you begin, ensure you have met the following requirements:

- [Install .NET Core](https://dotnet.microsoft.com/download)

### Installation
#### You can use Shell CLI or Visual Studio GUI
1. Clone this repository:

   ```shell
   git clone https://github.com/Meekdavid/Coure_API_Assesment.git
2. Navigate to the Project Directory
   ```shell
   cd Coure_API_Assesment
3. Restore Dependencies
    ```shell
    dotnet restore
4. Build Projects
    ```shell
    dotnet build 

## Usage
To run the API locally, use the following command:
  ```shell
  dotnet run
```
The API will be available at http://localhost:5000 (HTTP) and https://localhost:5001 (HTTPS) by default. Refer to the swagger API documentation for details on available endpoints and usage.
**https://41.203.112.130/CountrySummary/swagger/index.html**

## Deployment
- **Publish API:** Build and publish the API project into a folder on your development machine.
- **Copy the Published API to the Server:** Transfer the published API folder to your Windows server using methods like FTP, SCP, or shared network drives.
- **Create an IIS Site:** Open IIS Manager, expand the server node, right-click on "Sites," select "Add Website," configure with a unique name, physical path, binding details, and click "OK" to create the site.
- **Install the .NET Core Hosting Bundle:** If not already installed, install from [here](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-6.0.0-windows-hosting-bundle-installer)
- **Configure the Application Pool:** In IIS Manager, access "Application Pools," right-click your site's associated pool, choose "Advanced Settings," and set ".NET CLR Version" to "No Managed Code."
- **Test the API:** In IIS Manager, choose your site in the left pane, then click "Browse" to test your API in a web browser using the configured URL.
- **Troubleshoot:** In case of issues, check logs for errors and verify all required dependencies and configurations.
### **N/B:** You can deploy the .NET Core API to various platforms based on your requirements: Azure App Service, AWS Lambda, Docker, Et Cetera.

## Contributing
Contributions are welcome! If you'd like to contribute to this project, please follow these guidelines:
- Fork the repository.
- Create a new branch for your changes.
- Make your changes and commit them.
- Create a pull request, explaining the purpose of your changes.

<details>
  <summary><b>🛠️&nbsp;&nbsp;More&nbsp;About&nbsp;Project</b></summary>
  
### Author  
  * David Mboko | [Youtube](https://www.youtube.com/@davidmboko6502/featured) | [LinkedIn](https://www.linkedin.com/mwlite/in/david-mboko-25bb9019b) | [Academia](https://aksu.academia.edu/DavidMboko) |

### Resources
- [Click to View](https://dotnet.microsoft.com/en-us/learn)
</details>
