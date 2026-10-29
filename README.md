# ⚡ Sabong Prime - Live Network Dashboard

**Sabong Prime** is a real-time, interactive Blazor Server web application built for live entertainment broadcasting and wagering simulation. Featuring a sleek, high-contrast dark theme optimized for live sports/derby streaming, it integrates live video feeds, real-time odds tracking, and dynamic wallet/balance management.

---

## 🚀 Features

- **Live Broadcast Stage:** Integrated ultra-high-definition responsive video stream container (`1080p60` stream view).
- **Interactive Wagering Engine:** Real-time odds multiplier comparison for fighters (**Meron** vs. **Wala**).
- **Dynamic Wallet & Balance Tracking:** Automatically updates and deducts wagered amounts from the user's active session wallet, with automatic resets to the default starting balance (`₱12,500.00`) upon re-authentication or page initialization.
- **Secure Modal Workflows:** Built-in payment gateway selector (GCash, Maya, Bank Transfer, Arena VIP Cashier) with account validation and instant confirmation states.
- **Modern UI/UX:** Crafted with Tailwind CSS, utilizing custom animations, glassmorphism effects, and a high-end dark gaming/entertainment aesthetic.

---

## 🛠️ Tech Stack

- **Framework:** Blazor Server (`.NET 8+`)
- **Interactivity Mode:** Interactive Server (`@rendermode InteractiveServer`)
- **Styling:** Tailwind CSS (via CDN classes)
- **Routing & Navigation:** `NavigationManager`

---

## ⚙️ Getting Started & Installation

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later installed on your machine.
- An IDE such as Visual Studio 2022, Visual Studio Code, or JetBrains Rider.

### Running the App Locally

1. Clone the repository or open your Blazor project folder in your terminal:
   ```bash
   cd path/to/your/sabong-prime-project
