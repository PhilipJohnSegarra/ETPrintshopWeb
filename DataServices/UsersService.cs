using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ETPrintshopWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class UserService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<UserService> _logger;
    private List<ApplicationUser> _usersCache;

    public UserService(
        ApplicationDbContext dbContext,
        UserManager<ApplicationUser> userManager,
        IHttpContextAccessor httpContextAccessor,
        ILogger<UserService> logger)
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<List<ApplicationUser>> GetUsersAsync()
    {
        if (_usersCache == null)
        {
            try
            {
                _usersCache = await _dbContext.Users.Select(x => new ApplicationUser
                {
                    ImagePath = x.ImagePath,
                    Fullname = x.Fullname,
                    Id = x.Id,
                    Email = x.Email,
                    ContactNumber = x.ContactNumber,
                    Address = x.Address,
                    PasswordHash = "******",
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching users from database.");
                throw;
            }
        }
        return _usersCache;
    }

    public async Task<ApplicationUser> GetCurrentUserAsync()
    {
        var userId = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId != null)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                return new ApplicationUser
                {
                    ImagePath = user.ImagePath,
                    Fullname = user.Fullname,
                    Id = user.Id,
                    Email = user.Email,
                    ContactNumber = user.ContactNumber,
                    Address = user.Address,
                    PasswordHash = "******",
                };
            }
        }
        return null;
    }

    public void ClearCache()
    {
        _usersCache = null;
    }
}
