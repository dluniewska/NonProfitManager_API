﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NonProfitManager.Data;
using NonProfitManager.Models;

namespace NonProfitManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportsController : ControllerBase
    {
        private readonly NonProfitManagerDbContext _context;

        public TransportsController(NonProfitManagerDbContext context)
        {
            _context = context;
        }

        // GET: api/Transports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transport>>> GetTransports()
        {
          if (_context.Transports == null)
          {
              return NotFound();
          }
            return await _context.Transports.ToListAsync();
        }

        // GET: api/Transports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transport>> GetTransport(int id)
        {
          if (_context.Transports == null)
          {
              return NotFound();
          }
            var transport = await _context.Transports.FindAsync(id);

            if (transport == null)
            {
                return NotFound();
            }

            return transport;
        }

        // PUT: api/Transports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransport(int id, Transport transport)
        {
            if (id != transport.TransportId)
            {
                return BadRequest();
            }

            _context.Entry(transport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Transports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transport>> PostTransport(Transport transport)
        {
          if (_context.Transports == null)
          {
              return Problem("Entity set 'NonProfitManagerDbContext.Transports'  is null.");
          }
            _context.Transports.Add(transport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransport", new { id = transport.TransportId }, transport);
        }

        // DELETE: api/Transports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransport(int id)
        {
            if (_context.Transports == null)
            {
                return NotFound();
            }
            var transport = await _context.Transports.FindAsync(id);
            if (transport == null)
            {
                return NotFound();
            }

            _context.Transports.Remove(transport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransportExists(int id)
        {
            return (_context.Transports?.Any(e => e.TransportId == id)).GetValueOrDefault();
        }
    }
}
