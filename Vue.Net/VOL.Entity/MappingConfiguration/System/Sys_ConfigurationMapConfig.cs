using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Sys_ConfigurationMapConfig : EntityMappingConfiguration<Sys_Configuration>
    {
        public override void Map(EntityTypeBuilder<Sys_Configuration>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

