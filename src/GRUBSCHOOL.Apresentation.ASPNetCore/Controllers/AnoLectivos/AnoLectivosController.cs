using GRUBSCHOOL.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Apresentation.ASPNetCore.Controllers
{
    public class AnoLectivosController : Controller
    {
        private readonly IAnoLectivoApp _anoLectivoApp;

        public AnoLectivosController(IAnoLectivoApp anoLectivoApp)
        {
            _anoLectivoApp = anoLectivoApp;
        }

        // GET: AnoLectivoController
        public async Task<IActionResult> Index()
        {
            return View(await _anoLectivoApp.ListarTodos());
        }

        // GET: AnoLectivoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnoLectivoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnoLectivoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnoLectivoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnoLectivoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnoLectivoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnoLectivoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
