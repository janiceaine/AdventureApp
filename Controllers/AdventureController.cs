using Microsoft.AspNetCore.Mvc;

namespace AdventureApp.Controllers;

[Route("adventure")]
public class AdventureController : Controller
{
    [HttpGet("start")]
    public IActionResult Start()
    {
        var content =
            @"
            <p>The year is 2125. The corporate wars have ravaged the United States.</p>
            <p>You are in an abandoned Guitar Center.</p>
            <p>To your left is an ancient electric guitar.</p>
            <p>To your right is an dusty old drum kit.</p>
            <a href='/adventure/play/guitar'>Play the guitar.</a>
            <a href='/adventure/play/drums'>Play the drums.</a> ";
        return Content(content, "text/html");
    }

    [HttpGet("play/{instrument}")]
    public IActionResult Play(string instrument)
    {
        var content = "";
        if (instrument == "guitar")
        {
            content =
                @"The guitar hums to life. Kaleidoscopic colors fill the room.
            What song do you play?
            <a href='/adventure/stairway'>Stairway to Heaven</a>
            <a href='/adventure/smoke'>Smoke on the Water</a>";
        }
        if (instrument == "drums")
        {
            content =
                @"The drums seem to play themselves. A dark rhythm develops. Choose your fate and you must sing the song of choice: 
            <a href='/adventure/lockedout'>Locked out of Heaven</a>
            <a href='/adventure/mirrors'>Mirrors</a>";
        }

        return Content(content, "text/html");
    }

    [HttpGet("stairway")]
    public IActionResult Stairway(string stairway)
    {
        var content = "You play Stairway to Heaven. Poorly.";
        return Content(content, "text/html");
    }

    [HttpGet("smoke")]
    public IActionResult Smoke(string smoke)
    {
        var content = "You play Smoke on the water. You rock it out.";
        return Content(content, "text/html");
    }

    [HttpGet("lockedout")]
    public IActionResult Lockedout(string lockedout)
    {
        var content =
            "You make me feel like...&#x1F468;&#x1F3FB;&zwj;&#x1F3A4; I&apos;ve been lockedout. Heaven!";
        return Content(content, "text/html");
    }

    [HttpGet("mirrors")]
    public IActionResult Mirrors(string mirrors)
    {
        var content =
            "I&apos;m Looking right at the other half of me &#x1FA9E;!  <a href='/adventure/chickfila'>Chick-Fil-A</a>";
        return Content(content, "text/html");
    }

    [HttpGet("chickfila")]
    public IActionResult Mirrors(string chickfila)
    {
        var content = "ahhhhhhhhhhhhhh!";
        return Content(content, "text/html");
    }
}
