# Unit Conversion API

## Overview

This project is an ASP.NET Core Web API that converts values between different units of measurement.

## Supported Conversions

### Length

* Meter to Feet
* Feet to Meter

### Temperature

* Celsius to Fahrenheit
* Fahrenheit to Celsius

### Weight

* Kilogram to Pound
* Pound to Kilogram

## How to Run

1. Open the solution in Visual Studio.
2. Press F5 to run the application.
3. Open a browser and use the API endpoint.

Example:

https://localhost:7240/api/conversion/convert?value=10&from=meter&to=feet

## Sample Requests

Length:

https://localhost:7240/api/conversion/convert?value=10&from=meter&to=feet

Temperature:

https://localhost:7240/api/conversion/convert?value=100&from=celsius&to=fahrenheit

Weight:

https://localhost:7240/api/conversion/convert?value=10&from=kilogram&to=pound

## Design Decisions

* ASP.NET Core Web API used for implementation.
* Business logic separated into a service layer.
* Dependency Injection used for service management.
* Units and conversion factors are hardcoded as required by the assignment.
