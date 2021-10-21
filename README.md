# **Welcome to ChatMe application**

## Overview
Over the past few years, chat applications have become an extremely fashionable thing for users from all over the world. This application was designed to help people connect with their near and dear ones in a very friendly, easy and hassle-free manner.

The user can register or login if the account already exists, edit his or her profile, message to any person or even create chat groups to have a great communication with a lot of people at one time.


## Architecture
This application consists of three levels: 

**Data Access Layer**
  -	entities classes
  -	data context

**Business Logic Layer**
  -	business logic classes for every entity
  -	generic repository to work with entities

**Presentation Layer**
  -	user-friendly interface
  -	login/register pages
  -	profile page
  -	chat page

![image](https://user-images.githubusercontent.com/43004999/138233578-c47d4b04-0d5e-40c0-9e7f-0ab984276970.png)

## Technologies
The main role of the presentation layer is to display the UI and to respond to user interactions. We are going to use **Angular Framework** for it.

**MS SQL** is used as a main source of data to store. To access database, we will use **Entity Framework Core** with code first approach. Code first approach offers most control over the final appearance of the application code and the resulting database.

Authentication will be done using **JWT tokens**. We are going to have refresh token as well in order to secure user data in case the token is stolen.

To send messages we will use **SignalR**. It is an open-source library that enables server-side code to push content to clients instantly.
