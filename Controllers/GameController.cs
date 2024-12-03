using ServerGame106.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServerGame106.Data;

namespace ServerGame106.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<GameLevel> gameLevels = _context.GameLevels.ToList();
            return View(gameLevels);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GameLevel gameLevel)
        {
            if (ModelState.IsValid)
            {
                _context.GameLevels.Add(gameLevel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameLevel);
        }
        public IActionResult Edit(int id)
        {
            var gameLevel = _context.GameLevels.Find(id);
            return View(gameLevel);
        }

        [HttpPost]
        public IActionResult Edit(GameLevel gameLevel)
        {
            if (ModelState.IsValid)
            {
                _context.GameLevels.Update(gameLevel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameLevel);
        }
        public IActionResult Delete(int id)
        {
            var gameLevel = _context.GameLevels.Find(id);
            _context.GameLevels.Remove(gameLevel);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var gameLevel = _context.GameLevels.Find(id);
            ViewBag.GameLevelTitle = gameLevel.title;
            ViewBag.GameLevelId = gameLevel.LevelId;
            var question = _context.Questions.Where(q => q.levelId == id).ToList();
            return View(question);
        }
        public IActionResult CreateQuestion(int levelid)
        {
            Question question = new()
            {
                levelId = levelid
            };
            return View(question);
        }

        [HttpPost]
        public IActionResult CreateQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = question.levelId });
            }
            return View(question);
        }
        public IActionResult EditQuestion(int QuestionId)
        {
            var question = _context.Questions.Find(QuestionId);
            return View(question);
        }
        [HttpPost]
        public IActionResult EditQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Update(question);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = question.levelId });
            }
            return View(question);
        }
        public IActionResult DeleteQuestion(int QuestionId)
        {
            var question = _context.Questions.Find(QuestionId);
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = question.levelId });
        }
    }
}
