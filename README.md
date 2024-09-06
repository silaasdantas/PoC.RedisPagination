# Redis Pagination PoC 🚀

[![.NET](https://img.shields.io/badge/.NET-6.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/6.0)
[![Redis](https://img.shields.io/badge/Redis-6.x-red.svg)](https://redis.io/)
[![Docker](https://img.shields.io/badge/Docker-19.03.12-blue.svg)](https://www.docker.com/)

## Description

This is a Proof of Concept (PoC) for demonstrating **native pagination using Redis** with a .NET 6 console application. The project connects to a Redis instance, populates it with dummy data, and demonstrates paginating through the data stored in Redis using its native list capabilities.

## Features

- 🛠 **Redis pagination** using `ListRangeAsync` to fetch data from Redis.
- 📦 **Dockerized environment** for both the .NET 6 application and Redis.
- 📝 **Simulated data population** in Redis to showcase the pagination logic.
- ⚡ **Asynchronous operations** using `async/await`.

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started) (for running Redis and the application)
- [Redis](https://redis.io/)

## Project Setup

### 1. Clone the repository

```bash
git clone https://github.com/your-username/redis-pagination-poc.git
cd redis-pagination-poc
```

### 2. Clone the repository

```bash
docker-compose up --build
```
