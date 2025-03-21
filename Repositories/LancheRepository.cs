﻿using LancheMac.Models;
using LancheMac.Repositories.Interfaces;
using LancheMac.Context;
using Microsoft.EntityFrameworkCore;

namespace LancheMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {

        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanche => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchePreferidos => _context.Lanches.
            Where(l => l.IsLanchePreferido).
            Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l=>l.LancheId == lancheId);
        }
    }
}
