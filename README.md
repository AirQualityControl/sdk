<div align="center">

  # AirSnitch SDK 

![example workflow](https://github.com/AirQualityControl/sdk/actions/workflows/test_and_build.yml/badge.svg) ![version](https://img.shields.io/badge/version-0.7.0-yellow)
![badge](https://img.shields.io/badge/CLSCompliant-true-blue)

.NET (CLSCompliant) SDK that simplify integration with AirSnitch platform.
Proposed SDK provides a set of contracts and ADT(abstact data types) that facilitete you development process and makes integrations with a platform as easy as pie
</div>



## Getting Started:

### Installation

SDK is publish in GitHub Nuget registry.
To download it 

1. Add the following GitHub Nuget feed:
   ```sh
   dotnet nuget add source --username [ArturLavrov] --password [YourApiKey] --name github https://nuget.pkg.github.com/AirQualityControl/index.json
   ```
2. Install AirSnitch SDK:
   ```sh
   nuget install AirSnitch.SDK
   ```
4. Happy codding!
