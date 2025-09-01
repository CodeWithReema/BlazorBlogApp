# BlogApp - ASP.NET Core Razor Pages Blog Application

A simple blog application built with ASP.NET Core 9 and Razor Pages that allows users to view and create blog posts.

## Features

- **View Blog Posts**: Display a list of all blog posts with titles, content previews, and creation dates
- **Create New Posts**: Add new blog posts through a user-friendly form
- **In-Memory Storage**: Posts are stored in memory using a List<BlogPost> (no database required)
- **Modern UI**: Clean, responsive design using Bootstrap 5 and Bootstrap Icons
- **Hot Reload**: Real-time development with automatic reloading on code changes

## Prerequisites

- .NET 8 or 9 SDK
- Visual Studio Code with C# extension
- Git (optional)

## Getting Started

### 1. Install .NET SDK

Download and install the .NET 8 or 9 SDK from [Microsoft's official website](https://dotnet.microsoft.com/download).

### 2. Install VS Code Extensions

Install the following VS Code extensions for the best development experience:
- **C#** (ms-dotnettools.csharp)
- **.NET Runtime Install Tool** (ms-dotnettools.vscode-dotnet-runtime)

### 3. Run the Application

#### Option 1: Using VS Code
1. Open the project in VS Code
2. Press `F5` to start debugging, or
3. Use `Ctrl+Shift+P` and run "Tasks: Run Task" → "watch" for hot reload

#### Option 2: Using Command Line
```bash
# Navigate to the project directory
cd BlogApp

# Run the application
dotnet run

# Or run with hot reload
dotnet watch run
```

### 4. Access the Application

Open your browser and navigate to:
- **Home Page**: `https://localhost:(Port)` or `http://localhost:(Port)`
- **Blog Posts**: `https://localhost:(Port)/Blog`
- **Create Post**: `https://localhost:(Port)/CreatePost`

## Project Structure

```
BlogApp/
├── Models/
│   └── BlogPost.cs              # Blog post model
├── Services/
│   └── BlogService.cs           # In-memory blog post service
├── Pages/
│   ├── Index.cshtml             # Home page
│   ├── Blog.cshtml              # Blog posts list page
│   ├── CreatePost.cshtml        # Create new post page
│   └── Shared/
│       └── _Layout.cshtml       # Main layout template
├── .vscode/
│   ├── launch.json              # VS Code debug configuration
│   ├── tasks.json               # VS Code build tasks
│   └── extensions.json          # Recommended extensions
└── README.md                    # This file
```

## Features in Detail

### Blog Post Model
```csharp
public class BlogPost
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

### In-Memory Storage
Posts are stored in a `List<BlogPost>` within the `BlogService` class. The service includes:
- Sample posts for demonstration
- Methods to get all posts (ordered by creation date)
- Method to add new posts

### Pages

#### Home Page (`/`)
- Welcome message with links to blog features
- Quick access cards for viewing and creating posts

#### Blog Posts (`/Blog`)
- Displays all blog posts in a card layout
- Shows post title, content preview, and creation date
- "Create New Post" button for easy navigation
- Responsive design that works on all devices

#### Create Post (`/CreatePost`)
- Form to create new blog posts
- Client-side and server-side validation
- Automatic redirect to blog list after successful creation
- Clean, user-friendly interface

## Development Features

### Hot Reload
The application supports hot reload for real-time development:
```bash
dotnet watch run
```

### Debugging
VS Code is configured for debugging with:
- Launch configuration for starting the application
- Build tasks for compilation
- Breakpoint support and variable inspection

### Validation
The create post form includes:
- Required field validation
- Client-side validation using ASP.NET Core's built-in validation
- Server-side validation for security

## Customization

### Adding New Features
1. Create new Razor Pages in the `Pages/` directory
2. Add corresponding page models (`.cshtml.cs` files)
3. Update navigation in `_Layout.cshtml` if needed

### Styling
The application uses Bootstrap 5 for styling. You can customize the appearance by:
- Modifying the CSS in `wwwroot/css/site.css`
- Updating Bootstrap classes in the Razor pages
- Adding custom CSS classes

### Data Storage
To switch from in-memory storage to a database:
1. Add Entity Framework Core packages
2. Create a DbContext
3. Replace the `BlogService` with database operations
4. Update the dependency injection in `Program.cs`

## Troubleshooting

### Common Issues

1. **Port already in use**: Change the port in `Properties/launchSettings.json`
2. **Build errors**: Run `dotnet restore` to restore packages
3. **Hot reload not working**: Ensure you're using `dotnet watch run`

### Getting Help
- Check the [ASP.NET Core documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- Review the [Razor Pages tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/)

## License

This project is open source and available under the MIT License. 