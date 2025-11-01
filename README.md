### 🌐 Exploring HTTP in ASP.NET Core

Today, I built a small project to deepen my understanding of how **HTTP works in C# with ASP.NET Core** — focusing on **requests, responses, status codes, and the `HttpContext`**.

In this practice, I created a simple **web application that performs basic arithmetic operations (addition, subtraction, multiplication, and division)** based on query parameters sent through a **GET request**.

🔍 The app handles:

* Parsing query parameters from the URL (`firstNumber`, `secondNumber`, `operator`)
* Validating inputs and managing different **HTTP status codes** (`400 Bad Request` for invalid data, success responses for valid ones)
* Using the **`HttpContext` object** to access and manage request and response data directly

This exercise helped me understand how ASP.NET Core processes HTTP communication at a low level — before using controllers or MVC — and how to write clean, reliable responses that align with web standards.

💡 Example request:
`https://localhost:5001/?firstNumber=10&secondNumber=5&operator=sum`
👉 Response: `Resultado = 15`

I’m enjoying diving deeper into how ASP.NET Core handles web communication under the hood — it’s fascinating to see how everything ties together behind a simple browser request.

#ASPNetCore #CSharp #WebDevelopment #SoftwareEngineering #LearningJourney #HTTP #BackendDevelopment

---

Would you like me to make it sound a bit **more casual** (like a student learning post) or **more professional** (as for a portfolio or recruiter audience)?
