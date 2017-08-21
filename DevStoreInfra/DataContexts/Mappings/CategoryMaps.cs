using DevStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace DevStoreInfra.DataContexts.Mappings
{
    public class CategoryMaps : EntityTypeConfiguration<Category>
    {
        public CategoryMaps()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Title).HasMaxLength(60).IsRequired();
        }
    }
}
