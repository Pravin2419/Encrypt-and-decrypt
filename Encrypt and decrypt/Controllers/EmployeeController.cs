// Controllers/EmployeesController.cs
using Encrypt_and_decrypt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly demoprojectContext _context;
    private readonly EncryptionService _encryptionService;

    public EmployeesController(demoprojectContext context, EncryptionService encryptionService)
    {
        _context = context;
        _encryptionService = encryptionService;
    }
    [HttpPost("register")]
    public IActionResult Register(Employee employee)
    {
        try
        {

            // Encrypt the password before saving
            employee.Email = _encryptionService.Encrypt(employee.Email);
            employee.FirstName = _encryptionService.Encrypt(employee.FirstName);
            employee.LastName = _encryptionService.Encrypt(employee.LastName);


            _context.Employees.Add(employee);
            _context.SaveChanges();

            return Ok("User is registered successfully");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
     [HttpPost("login")]
    public IActionResult Login(Employee employee)
        {
            try
            {

                // Decrypt sensitive information for login verification
                string decryptedFristName = _encryptionService.Decrypt(employee.FirstName);
                string decryptedEmail = _encryptionService.Decrypt(employee.Email);
                string decryptedLastName = _encryptionService.Decrypt(employee.LastName);

                // Implement actual login logic here

                return Ok("Login successful");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }






}
