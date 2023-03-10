using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Listing.Models;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_Listing.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly Restaurant_ListingContext _db;

    public CuisinesController(Restaurant_ListingContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      ViewBag.PageTitle = "All Cuisines";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add A New Cuisine";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines
                            .Include(cuisine => cuisine.Restaurants)
                            .FirstOrDefault(cuisine => cuisine.CuisineId == id);
      ViewBag.PageTitle = $"Details for {thisCuisine.Name}";
      return View(thisCuisine);
    }

    public ActionResult Edit(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      ViewBag.PageTitle = $"Editing {thisCuisine.Name}";
      return View(thisCuisine);
    }

    [HttpPost]
    public ActionResult Edit(Cuisine cuisine)
    {
      _db.Cuisines.Update(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(thisCuisine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      _db.Cuisines.Remove(thisCuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}