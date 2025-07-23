using SignalRChatApp.Hubs; // Make sure namespace matches the folder where ChatHub.cs exists

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSignalR(); // Add SignalR

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Serve static files like index.html, JS, CSS, etc.
app.UseHttpsRedirection();
app.UseStaticFiles(); // This must come BEFORE routing

app.UseRouting();

app.UseAuthorization();

// Map Razor Pages and static assets
app.MapRazorPages().WithStaticAssets();
app.MapStaticAssets();

// Map the SignalR hub
app.MapHub<ChatHub>("/chathub");

app.Run();
