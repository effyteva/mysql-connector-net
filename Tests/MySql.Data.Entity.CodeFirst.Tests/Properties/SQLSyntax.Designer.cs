﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Data.Entity.CodeFirst.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SQLSyntax {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SQLSyntax() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Data.Entity.CodeFirst.Tests.Properties.SQLSyntax", typeof(SQLSyntax).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`visitante`.`nCdSite`, 
        ///COUNT(DISTINCT `visitante`.`sDsIp`) AS `C1`
        ///FROM `visitante`
        /// GROUP BY 
        ///`visitante`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupBy {
            get {
                return ResourceManager.GetString("CountGroupBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`Extent4`.`nCdSite`, 
        ///COUNT(DISTINCT `Extent4`.`sDsIp`) AS `C1`
        ///FROM `pagina` AS `Extent3` INNER JOIN `visitante` AS `Extent4` ON `Extent3`.`nCdVisitante` = `Extent4`.`nCdVisitante`
        /// GROUP BY 
        ///`Extent4`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupBy2 {
            get {
                return ResourceManager.GetString("CountGroupBy2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`Extent5`.`nCdSite`, 
        ///COUNT(DISTINCT `Extent5`.`sDsIp`) AS `C1`
        ///FROM `pagina` AS `Extent3` INNER JOIN `visitante` AS `Extent4` ON `Extent3`.`nCdVisitante` = `Extent4`.`nCdVisitante` LEFT OUTER JOIN `visitante` AS `Extent5` ON `Extent3`.`nCdVisitante` = `Extent5`.`nCdVisitante`
        /// GROUP BY 
        ///`Extent5`.`nCdSite`) AS `Project3`
        ///  .
        /// </summary>
        internal static string CountGroupBy2EF5 {
            get {
                return ResourceManager.GetString("CountGroupBy2EF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`visitante`.`nCdSite`, 
        ///COUNT(DISTINCT `visitante`.`sDsIp`) AS `C1`
        ///FROM `visitante`
        /// GROUP BY 
        ///`visitante`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupByEF5 {
            get {
                return ResourceManager.GetString("CountGroupByEF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project1`.`ID`, 
        ///  `Project1`.`Title`, 
        ///  `Project1`.`ReleaseDate`, 
        ///  `Project1`.`Genre`, 
        ///  `Project1`.`Price`, 
        ///  `Project1`.`Data`, 
        ///  `Project1`.`Director_ID`
        ///  FROM `Movies` AS `Project1`
        ///   WHERE `Project1`.`ReleaseDate` &gt;= @p__linq__0
        ///   ORDER BY 
        ///  `Project1`.`ReleaseDate` DESC LIMIT 2.
        /// </summary>
        internal static string NestedOrderBy {
            get {
                return ResourceManager.GetString("NestedOrderBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`ID`, 
        ///`Project1`.`Title`, 
        ///`Project1`.`ReleaseDate`, 
        ///`Project1`.`Genre`, 
        ///`Project1`.`Price`, 
        ///`Project1`.`Data`, 
        ///`Project1`.`Director_ID`
        ///FROM `Movies` AS `Project1`
        /// WHERE (LOCATE(@p__linq__0, `Project1`.`Title`)) &gt; 0
        /// ORDER BY 
        ///`Project1`.`ID` DESC LIMIT 10.
        /// </summary>
        internal static string QueryWithOrderByTakeContains {
            get {
                return ResourceManager.GetString("QueryWithOrderByTakeContains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`HarborId`, 
        ///`Project1`.`Description`, 
        ///`Project1`.`C2` AS `C1`, 
        ///`Project1`.`ShipId`, 
        ///`Project1`.`HarborId1`, 
        ///`Project1`.`Description1`, 
        ///`Project1`.`C1` AS `C2`, 
        ///`Project1`.`CrewMemberId`, 
        ///`Project1`.`ShipId1`, 
        ///`Project1`.`RankId`, 
        ///`Project1`.`ClearanceId`, 
        ///`Project1`.`Description2`, 
        ///`Project1`.`RankId1`, 
        ///`Project1`.`Description3`, 
        ///`Project1`.`ClearanceId1`, 
        ///`Project1`.`Description4`
        ///FROM (SELECT
        ///`Extent1`.`HarborId`, 
        ///`Extent1`.`Description`, 
        ///`Join3`.`Shi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShipQueryMalformedDueMultipleProjecttionsCorrected {
            get {
                return ResourceManager.GetString("ShipQueryMalformedDueMultipleProjecttionsCorrected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`HarborId`, 
        ///`Project1`.`Description`, 
        ///`Project1`.`C2` AS `C1`, 
        ///`Project1`.`ShipId`, 
        ///`Project1`.`HarborId1`, 
        ///`Project1`.`Description1`, 
        ///`Project1`.`C1` AS `C2`, 
        ///`Project1`.`CrewMemberId`, 
        ///`Project1`.`ShipId1`, 
        ///`Project1`.`RankId`, 
        ///`Project1`.`ClearanceId`, 
        ///`Project1`.`Description2`, 
        ///`Project1`.`RankId1`, 
        ///`Project1`.`Description3`, 
        ///`Project1`.`ClearanceId1`, 
        ///`Project1`.`Description4`
        ///FROM (SELECT
        ///`Extent1`.`HarborId`, 
        ///`Extent1`.`Description`, 
        ///`Join3`.`Shi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShipQueryMalformedDueMultipleProjecttionsCorrectedEF6 {
            get {
                return ResourceManager.GetString("ShipQueryMalformedDueMultipleProjecttionsCorrectedEF6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project1`.`ID` AS `C1`
        ///  FROM `Movies` AS `Project1`
        ///   WHERE (`Project1`.`ID`) = @p__linq__0
        ///   ORDER BY 
        ///  `Project1`.`ID` ASC.
        /// </summary>
        internal static string UnknownProjectC1 {
            get {
                return ResourceManager.GetString("UnknownProjectC1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`ID` AS `C1`
        ///FROM `Movies` AS `Project1`
        /// WHERE (((`Project1`.`ID`) = @p__linq__0) AND (NOT ((`Project1`.`ID` IS  NULL) OR (@p__linq__0 IS  NULL)))) OR ((`Project1`.`ID` IS  NULL) AND (@p__linq__0 IS  NULL))
        /// ORDER BY 
        ///`Project1`.`ID` ASC.
        /// </summary>
        internal static string UnknownProjectC1EF6 {
            get {
                return ResourceManager.GetString("UnknownProjectC1EF6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `MovieReleases` SET `Name`=&apos;Director\&apos;s Cut&apos; WHERE (`Id` = 1) AND (`Name` = &apos;Commercial&apos;); SELECT `Timestamp` FROM `MovieReleases`  WHERE  row_count() &gt; 0 and (`Id` = 1) AND (`Name` = &apos;Director\&apos;s Cut&apos;).
        /// </summary>
        internal static string UpdateWithSelect {
            get {
                return ResourceManager.GetString("UpdateWithSelect", resourceCulture);
            }
        }
    }
}
