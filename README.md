# ASP.NET Core MVC - Partial Views Explained

This project is focused on understanding and implementing **Partial Views** in ASP.NET Core MVC 6. The goal is to explore how to break down large views into smaller, reusable components for better code organization and maintainability.

## 📌 Topics Covered

- ✅ What is a Partial View?
- ✅ Types of Partial Views
- ✅ Creating and Rendering Partial Views
- ✅ Passing Data to Partial Views using `ViewBag`, `ViewData`, and `TempData`
- ✅ Standard Partial View Implementation with Layouts

---

## 📖 What is a Partial View?

A **Partial View** is a reusable view (like a sub-view) that can be embedded inside other views. It's used to modularize the UI and avoid code repetition.

### 🔹 When to Use:
- To split large HTML pages into smaller manageable components.
- To reuse headers, footers, menus, forms, etc., across multiple views.

---

## 🧩 Types of Partial Views

1. **Standard Partial View**  
   - Rendered using `@Html.Partial()` or `@await Html.PartialAsync()`.
   - Doesn't support View lifecycle (i.e., no controller call).

2. **Strongly Typed Partial View**  
   - Accepts a model, allowing better control and IntelliSense.
   - Rendered using `@Html.Partial("ViewName", model)`.

3. **Dynamic Partial View**  
   - Loaded using AJAX for partial page updates without a full refresh.

---

## 🛠️ How to Implement

### 1. Create a Partial View

Inside the `Views/Shared/` folder:
```bash
PartialViewName.cshtml
