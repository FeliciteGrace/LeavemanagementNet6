﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Leavemanagement.Web.Data;
using Leavemanagement.Web.Configuration;
using AutoMapper;
using Leavemanagement.Web.Models;
using Leavemanagement.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using Leavemanagement.Web.Constants;

namespace Leavemanagement.Web.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;
        public readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            return View(mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync()));
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);

            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await leaveAllocationRepository.AllocateLeave(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
