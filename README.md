# SignalR WebSocket Chat Demo

This project is a **real-time chat application** built with **ASP.NET Core SignalR**.  
It demonstrates how **WebSockets** and **SignalR** enable instant bi-directional communication between the server and multiple connected clients.

---

## Features
- Real-time chat messaging between multiple clients
- SignalR Hub for message broadcasting
- Simple UI (HTML/JS) to send and receive messages instantly
- Uses WebSocket transport (fallback to others if unavailable)

---

## Technology Stack
- **ASP.NET Core 8 or Above**
- **SignalR (Microsoft.AspNetCore.SignalR)**
- **HTML + JavaScript (SignalR client library)**

---

## Prerequisites
1. [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
2. [Visual Studio 2022](https://visualstudio.microsoft.com/) (or VS Code)
3. Git installed on your machine

---

## Setup & Run
### 1. Clone the repository
```bash
git clone https://github.com/<your-username>/SignalR-WebSocket-Demo.git
cd SignalR-WebSocket-Demo

### 2. Build the project
```bash
   dotnet build

### 3. Run the application
```bash
   dotnet run

### 4. Open the browser
   Navigate to: https://localhost:7081/index.html
   Open multiple tabs or browsers to see real-time messaging in action

### Project Structure
```bash
   SignalR-WebSocket-Demo/
    │
    ├── Hubs/
    │   └── ChatHub.cs        # SignalR Hub for messaging
    │
    ├── wwwroot/
    │   └── index.html        # Simple chat frontend
    │
    ├── Program.cs            # SignalR & middleware configuration
    ├── SignalRChatApp.csproj # Project file
    └── README.md             # Project documentation


### Screenshot
  
