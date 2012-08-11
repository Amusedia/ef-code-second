#ef-code-second#

Templates for generating context, entities, entity configurations, repositories, and db migrations configuration from Entity Framework model (edmx).

##Context.tt##
This template creates the DbContext subclass that contains the repositories for accessing table data.  The generated constructor will initialize the repositories by passing the concrete DbSet objects to the repositories' constructors.  See repository.tt section for more information on repositories. The subclass also overrides OnModelCreating method to use entity configurations and calls a partial method CustomOnModelCreating method that can be implemented to contain additional model creation logic.

##Entity.tt##
This template generates poco for the entities defined in the model.  The generated poco also implements IValidatableObject interface and contains a partial method CustomValidate that can be implemented to contain additional validation logic.

##EntityTypeConfiguration.tt##
This template generates EntityTypeConfiguration classes for the entities that configures the model using Fluent Api.  This template will handles cases that weren't well supported using by other templates such as row version or decimal type.

##ComplexTypeConfiguration.tt##
N/A

##Repository.tt##
This template generates classes that implements .Net version of repository pattern (aka Table Data Gateway pattern from Folwer).  The repository inheriates IDbSet and is a wrapper for DbSet class.  The repository adds additional method based on the entity such as if the entity contains RowVersion it will create GetMaxRowVersion for the repository.

##DbMigrationsConfiguration.tt##
This template generates the DbMigrationsConfiguration class that uses the Db Migration feature of Entity Framework v4.3.1 and later.  The generated partial class contains instruction on how to create migration classes in the comments section.