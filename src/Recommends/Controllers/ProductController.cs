using Microsoft.AspNetCore.Mvc;
using Recommends.ViewModels;

namespace Recommends.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        
        [HttpPost]
        [Route("Visit")]
        public IActionResult Visit([FromBody]RelationshipViewModel visit)
        {
            return Ok(visit);
        }

        [HttpPost]
        [Route("AddCart")]
        public void AddCart([FromBody]RelationshipViewModel addCart)
        {
        }

        [HttpPost]
        [Route("Wishlist")]
        public void Wishlist([FromBody]RelationshipViewModel addCart)
        {
        }

        [HttpPost]
        [Route("Redemption")]
        public void Redemption([FromBody]RelationshipViewModel addCart)
        {
        }

    }
}
