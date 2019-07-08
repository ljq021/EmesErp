using Microsoft.EntityFrameworkCore;

namespace Emes.Core.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
