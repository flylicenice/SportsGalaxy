# 🏆 SportsGalaxy

SportsGalaxy is a desktop-based sports event ticketing and management system developed using **C# WinForms**. The platform enables users to create and join sports events, receive QR-code-based digital tickets via email, and manage their event participation. An administrative module is also included for event moderation and administrator management.

---

## 📌 Features

### 👤 User Features

#### User Registration

* Create a new account
* Secure account authentication
* Input validation

#### User Login

* User authentication
* Role-based access control
* Session management

#### Event Creation

Users can create sports events by providing:

* Event Name
* Event Description
* Date and Time
* Location
* Maximum Number of Attendees

#### Join Event

* Browse available events
* View event details
* Register participation
* Automatic slot management

#### Cancel Participation

* View joined events
* Cancel event registration
* Release occupied slots automatically

#### QR Code Ticket Generation

After successful registration:

* A unique ticket is generated
* QR Code is created using QRCoder
* Ticket information is linked to the user and event

#### Email Notification

The system automatically sends:

* Registration confirmation emails
* QR Code tickets as attachments
* Event participation details

---

### 🛡️ Admin Features

#### Event Management

Administrators can:

* View all events
* Update event information
* Remove inappropriate or expired events

#### Administrator Management

Administrators can:

* Add new administrators
* Manage existing administrators
* Control system access permissions

---

## 🛠️ Technologies Used

| Technology           | Purpose                         |
| -------------------- | ------------------------------- |
| C# WinForms          | Desktop Application Development |
| SQL Server / LocalDB | Database Management             |
| BCrypt.Net           | Password Hashing                |
| QRCoder              | QR Code Generation              |
| MailKit              | Email Services                  |

---

## 🗄️ Database Design

### User Table

| Field        |
| ------------ |
| matric_no       |
| Username     |
| Email        |
| Password |
| Role         |

### Event Table

| Field        |
| ------------ |
| EventID      |
| EventName    |
| Description  |
| Date         |
| Time         |
| Location     |
| MaxAttendees |
| matric_no    |

### JOIN_EVENTS Table (Bridge Table)

| Field           |
| --------------- |
| matric_no       |
| eventId         |

### Admin Table

| Field           |
| --------------- |
| AdminID         |
| Password        |

### Ticket Table

| Field           |
| --------------- |
| Ticket_code     |
| EventId         |
| matric_no       |

---

## 🔄 System Workflow

```text
User Registration
        ↓
User Login
        ↓
Browse Events
        ↓
Join Event
        ↓
Generate QR Ticket
        ↓
Send Ticket via Email
        ↓
Attend Event
```

---

## 🎫 QR Ticket System

Every successful event registration generates:

* Unique Ticket ID
* Unique QR Code

The QR code can be used for:

* Event verification
* Attendance tracking
* Ticket validation

---

## 📧 Email Integration

SportsGalaxy uses MailKit to automatically send:

* Event registration confirmations
* QR-code-based tickets
* Event participation details

This eliminates the need for physical tickets and improves user convenience.

---

## Admin Login Credentials

ID = 1 Password = 1
