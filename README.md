# Async Inn Management System

## Introduction
Welcome to Async Inn Management System! This web application is designed to manage hotels, rooms, and amenities for a hotel chain. It allows users to perform basic CRUD operations on hotels, rooms, and amenities through a RESTful API.

![ERD1](./Async__Inn-Lab14/Async__Inn/ERD1)

## Entity-Relationship Diagram (ERD)
The application's database schema is represented by the following ERD:



## Overview of Relationships
The application consists of three main entities: Hotel, Room, and Amenity. Here's an overview of their relationships:

1. **Hotel and Room:**
   - Each hotel can have multiple rooms.
   - This represents a one-to-many relationship, where one hotel has multiple associated rooms.

2. **Hotel and Amenity:**
   - Each hotel can offer multiple amenities.
   - This also represents a one-to-many relationship, where one hotel has multiple associated amenities.

3. **User and Hotel:**
   - A user can book multiple hotels, and each hotel can be booked by multiple users.
   - This represents a many-to-many relationship, typically implemented using an association table to track bookings.

4. **User and Room:**
   - A user can reserve multiple rooms, and each room can be reserved by multiple users.
   - Similar to the user-hotel relationship, this is another many-to-many relationship that requires an association table to track reservations.

5. **Hotel and Room and Amenity:**
   - The hotel can offer multiple rooms and amenities, and each room and amenity can be present in multiple hotels.
   - Both of these relationships represent  many-to-many relationships, which need an association table to link rooms/amenities to hotels.

## Getting Started
1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred code editor.
3. Ensure you have a local database setup and update the connection string in the `appsettings.json` file.
4. Run the application and test the API endpoints using tools like Postman.

## Endpoints
Here are the main API endpoints for each entity:

- `/api/hotels`: CRUD operations for hotels.
- `/api/rooms`: CRUD operations for rooms.
- `/api/amenities`: CRUD operations for amenities.

## Dependencies
- .NET Core 5.0
- Entity Framework Core
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Mvc.NewtonsoftJson

## Contribution
Contributions to the Async Inn Management System are welcome! If you find any bugs or have suggestions for improvement, please feel free to create a pull request or submit an issue.

## Support
If you encounter any issues or need assistance, please reach out to [ahmadjamalkhater@Gmail.com].

---
# Lab 13: Dependency Injection & Repository Design Pattern

## Introduction
In this lab, we have refactored our Async Inn Management System to implement the Dependency Injection and Repository Design Pattern. The goal of this refactoring is to improve the architecture of the application, making it more maintainable, scalable, and testable.

## Dependency Injection and Repository Design Pattern
**Dependency Injection (DI):** Dependency Injection is a design pattern used to achieve loose coupling between classes in an application. It allows the injection of dependencies (such as services, interfaces, or other objects) into a class from an external source rather than the class creating those dependencies itself. This promotes modularity, testability, and easier extensibility.

**Repository Design Pattern:** The Repository Pattern is a design pattern that abstracts the data access logic from the rest of the application. It provides a consistent interface for data operations and isolates the application from the underlying data storage, such as a database. The repository acts as a mediator between the data layer and the business logic layer.

## Implementation in the App
To implement the Dependency Injection and Repository Design Pattern in our Async Inn Management System, we followed these steps:

1. **Repository Interfaces:** Created interfaces for each controller (Hotel, Room, Amenity) that define the required method signatures for CRUD operations to the database.

2. **Dependency Injection:** Refactored the controllers to depend on the respective repository interfaces instead of the DbContext directly. This decouples the controllers from the data access logic, making them more maintainable and easier to test.

3. **Repository Services:** Implemented services for each controller that implement the corresponding repository interfaces. These services encapsulate the data access logic and handle database interactions.

4. **Interface Implementation:** The services use the Entity Framework Core DbContext to interact with the database and provide the required data manipulation operations.

5. **Controller Update:** Updated the controllers to use the appropriate methods from the repository interfaces, thus achieving the same behavior as in Lab 12 while maintaining better architecture.

## Endpoints and Testing
We have verified that the API endpoints continue to work as expected using tools like Postman. The refactoring does not change the external behavior of the application but improves its internal structure.

## Getting Started
1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred code editor.
3. Review the changes made to the controllers and services to understand the implementation of DI and the Repository Pattern.
4. Test the API endpoints using Postman or other API testing tools to ensure that the application is working correctly.

## Dependencies
- .NET Core 5.0
- Entity Framework Core
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Mvc.NewtonsoftJson

## Contribution
Contributions to the Async Inn Management System are welcome! If you find any bugs or have suggestions for improvement, please feel free to create a pull request or submit an issue.

---
# Lab 14


## API Endpoints

- **Rooms**
  - `GET /api/Rooms`: Get all rooms
  - `GET /api/Rooms/{roomId}`: Get a specific room by ID
  - `POST /api/Rooms`: Add a new room
  - `PUT /api/Rooms/{roomId}`: Update a room by ID
  - `DELETE /api/Rooms/{roomId}`: Delete a room by ID
  - `POST /api/Rooms/{roomId}/Amenity/{amenityId}`: Add an amenity to a specific room
  - `DELETE /api/Rooms/{roomId}/Amenity/{amenityId}`: Remove an amenity from a specific room

- **Amenities**
  - `GET /api/Amenities`: Get all amenities
  - `GET /api/Amenities/{amenityId}`: Get a specific amenity by ID
  - `POST /api/Amenities`: Add a new amenity
  - `PUT /api/Amenities/{amenityId}`: Update an amenity by ID
  - `DELETE /api/Amenities/{amenityId}`: Delete an amenity by ID

- **Hotels**
  - `GET /api/Hotels`: Get all hotels
  - `GET /api/Hotels/{hotelId}`: Get a specific hotel by ID
  - `GET /api/Hotels/{hotelId}/Rooms`: Get all rooms for a specific hotel
  - `POST /api/Hotels/{hotelId}/Rooms`: Add a new room to a specific hotel
  - `GET /api/Hotels/{hotelId}/Rooms/{roomNumber}`: Get details of a specific room in a hotel
  - `PUT /api/Hotels/{hotelId}/Rooms/{roomNumber}`: Update details of a specific room in a hotel
  - `DELETE /api/Hotels/{hotelId}/Rooms/{roomNumber}`: Delete a specific room from a hotel

## Usage

1. Start the application: `dotnet run`
2. Access the API using a web browser or API client like Postman.
3. Use the provided endpoints to manage hotel rooms, amenities, and hotels.

## Technologies Used


- ASP.NET Core
- Entity Framework Core
- SQL Server
- C#





