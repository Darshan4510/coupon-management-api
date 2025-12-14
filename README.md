# Coupon Management API

## Project Overview
This project is a simple Coupon Management system built as part of the Anshumat Foundation assignment.
It allows creating coupons with eligibility rules and finding the best applicable coupon for a user and cart.

## Tech Stack
- Language: C#
- Framework: ASP.NET Core Web API (.NET 8)
- Storage: In-memory (List)
- API Documentation: Swagger (Swashbuckle)

## How to Run

### Prerequisites
- .NET SDK 8.0 or later
- Visual Studio / VS Code

### Steps
1. Clone the repository:https://github.com/Darshan4510/coupon-management-api.git
2. Open the project in Visual Studio
3. Run the project (HTTPS)
4. Open Swagger:https://localhost:<port>/swagger


## APIs

### Create Coupon
POST `/api/coupons`

### List Coupons
GET `/api/coupons`

### Best Coupon
POST `/api/coupons/best`

Evaluates all coupons and returns the best one based on:
- Eligibility rules
- Highest discount amount

## Notes
- Coupons are stored in memory
- No authentication required
- Designed for clarity and correctness

## AI Usage
AI tools were used for guidance, debugging, and understanding API design concepts.


