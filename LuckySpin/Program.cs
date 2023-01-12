var builder = WebApplication.CreateBuilder(args);

/* Install Services using the builder.Services methods
 *  TODO: use the AddControllers method to enable controllers
 */
builder.Services.AddControllers();

//Builds the app with the added services
var app = builder.Build();


/* Configure Middleware in the HTTP Request Pipeline
   • "UseStaticFiles" to recognizste static folders and files in the wwwroot directory
   • TODO: add "UseRouting" to recognize custom "Routes" in place of folders and files
   • "UseExceptionHandler" to provide a default error page when not in development
 */

app.UseStaticFiles();
app.UseRouting();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Spinner/Error");
}


/* Configure Routing with a general pattern
 *  and a default setting if the URL is just the base site
 *  TODO: Add a range(1,9) method to constrain luck between 1 and 9
 */
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{luck:range(1,9)}",
    defaults: new
    {
        controller = "Spinner",
        action = "Index",
        luck = 7
    });

app.Run();

