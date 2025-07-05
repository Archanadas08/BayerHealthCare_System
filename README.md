# BayerHealthCare_System

This project is a Hospital booking management system built using ASP.NET Core MVC .

Login/Registration User can login/Register as a Doctor / Patient

**User Management ** user can view, create, edit doctoer appointments they made can Edit user information password management. userprofile include patient name ,age, gender, selected doctor, appointment date, time and reason

Doctor Management (Administrator) Doctoers can manage creating, editing availablity and leaves. Doctor profiles include information such as name, email, phone number, and a photo upload option.

Technologies Used

Backend

C# ASP.NET Core endpoint: /doctor { "name": string,
"email": string, availability:string "type": "doctor", "patient":{ "name":string, "appointmentDate": date "reason":string
} }

endpoint:/patient "patient":{ "name":string, "appointmentDate": date "reason":string
}

data stored in MongoDB

