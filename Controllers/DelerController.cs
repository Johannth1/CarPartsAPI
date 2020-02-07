using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using CarPartsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CarPartsAPI.Controllers{
    [ApiController]
    [Route("[controller]")]


    public class DelerController : ControllerBase {

        private readonly DelerContext _context;

        public DelerController(DelerContext context) {
            _context = context;
        }

        [HttpGet]

        public async Task<IEnumerable<Deler>> Get(){
            List<Deler> DelerList = await _context.Deler.ToListAsync();
            return DelerList;
        }

        [HttpPut]
        public async Task<Deler> Put(Deler updateDeler){
            _context.Update(updateDeler);
            await _context.SaveChangesAsync();
            return updateDeler;
        }

        [HttpPost]
        public async Task<Deler> Post(Deler newDeler){
            _context.Deler.Add(newDeler);
            await _context.SaveChangesAsync();
            return newDeler;
        }       

        [HttpDelete("{name}")]
        public async Task<Deler> Delete(string name){
            Deler delerToDelete = await _context.Deler.FirstAsync( deler => deler.Name.Equals(name) );
            _context.Deler.Remove(delerToDelete);
            await _context.SaveChangesAsync();
            return delerToDelete;
        }

    }
}