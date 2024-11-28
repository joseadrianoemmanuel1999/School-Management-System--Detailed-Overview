using Microsoft.EntityFrameworkCore;

namespace School.Data;

public class SchoolDBContext:DbContext
{
    public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
    {
        
    }
}