using Microsoft.AspNetCore.Mvc;
namespace Portfolio_1.Controllers;
public class HelloController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my Index!";
    }
    
    // Route declaration Option B
    // This will go to "localhost:5XXX/user/more"
    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects";
    }
    
    // Post request example
    // This will go to "localhost:5XXX/submission"
    [HttpGet("contact")]
    // Don't worry about what the form is doing for now. We'll get to those soon!
    // Note: You will not be able to navigate to this route! This is for demonstration only!
    public string Contact()
    {
    	// Logic for post request here
        return "This is my Contact!";
    }
}

