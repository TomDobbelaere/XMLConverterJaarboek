﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XmlConverterJaarboek.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>01,02=Vlaams-Brabant</string>
  <string>11,12,13=Antwerpen</string>
  <string>21=region bruxelles - Brussels gewest</string>
  <string>25=Brabant Wallon</string>
  <string>31,32,33,34,35,36,37,38=West-Vlaanderen</string>
  <string>41,42,43,44,45,46=Oost-Vlaanderen</string>
  <string>51,52,53,54,55,56,57=Hainaut</string>
  <string>61,62,63,64=Liege</string>
  <string>71,72,73=Limburg</string>
  <string>81,82,83,84,85=Luxembourg</string>
  <string>91,92,93=Namur</string>
  <string>A,a,C=A L'etranger - in het Buitenland</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ProvArrondMapping {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ProvArrondMapping"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Antwerpen</string>
  <string>region bruxelles - Brussels gewest</string>
  <string>Vlaams-Brabant</string>
  <string>Brabant Wallon</string>
  <string>West-Vlaanderen</string>
  <string>Oost-Vlaanderen</string>
  <string>Hainaut</string>
  <string>Liege</string>
  <string>Limburg</string>
  <string>Luxembourg</string>
  <string>Namur</string>
  <string>A L'etranger - in het Buitenland</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ProvArrondMapOrder {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ProvArrondMapOrder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>ANAT-PATH.</string>
  <string>ANEST-REANIM.</string>
  <string>BIOL. CLINIQUE</string>
  <string>CARDIOLOGIE</string>
  <string>CHIRURGIE</string>
  <string>CH. PLASTIQUE</string>
  <string>DERMATO-VENER.</string>
  <string>GASTRO-ENTERO.</string>
  <string>GERIATRIE</string>
  <string>GYNECOLOGIE</string>
  <string>MED. URGENCE</string>
  <string>MED. INTERNE</string>
  <string>MED. NUCLEAIRE</string>
  <string>MED. PHYSIQUE</string>
  <string>NEUROCHIRURGIE</string>
  <string>NEUROLOGIE</string>
  <string>NEUROPEDIATRIE</string>
  <string>OPHTALMOLOGIE</string>
  <string>ORTHOPEDIE</string>
  <string>O.R.L.</string>
  <string>PEDIATRIE</string>
  <string>PNEUMOLOGIE</string>
  <string>PSYCHIATRIE</string>
  <string>R. DIAGNOSTIC</string>
  <string>R.THERAPIE-ONCO.</string>
  <string>RHUMATOLOGIE</string>
  <string>SOINS INTENSIFS</string>
  <string>STOMATOLOGIE</string>
  <string>UROLOGIE</string>
  <string>READAPTION</string>
  <string>HEALTH DATA MAN.</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SpecialisationOrder {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SpecialisationOrder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(InExtenso, 'KLINISCHE BIOL.', 'BIOL. CLINIQUE'), 'PLASTISCHE CH.', 'CH. PLASTIQUE'), 'MAAG-DARM.', 'GASTRO-ENTERO.'), 'URGENTIEGEN.', 'MED. URGENCE'), 'INWENDIGE GEN.', 'MED. INTERNE'),
          'KERNGENEESKUNDE', 'MED. NUCLEAIRE'), 'FYSISCHE GEN.', 'MED. PHYSIQUE'), 'KINDERNEUROLOGIE', 'NEUROPEDIATRIE'), 'OOGHEELKUNDE', 'OPHTALMOLOGIE'), 'KINDERGEN.', 'PEDIATRIE'), 'R. DIAGNOSE', 'R. DIAGNOSTIC'), 'REUMATOLOGIE', 'RHUMATOLOGIE'), 'INTENS. ZORGEN', 'SOINS INTENSIFS'), 'REVALIDATIE', 'READAPTION'), 'N.K.O.', 'O.R.L.') AS InExtensoNew")]
        public string InExtensoNew {
            get {
                return ((string)(this["InExtensoNew"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>GER</string>
  <string>ENDOC</string>
  <string>NEPH</string>
  <string>HEMAT</string>
  <string>SI</string>
  <string>MU</string>
  <string>ONCO_MED</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection InternalOrder {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["InternalOrder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Internistes gériatres,Internisten geriaters</string>
  <string>Internistes endocrino-diabétologues,Internisten endocrino-diabetologen</string>
  <string>Internistes néphrologues,Internisten nefrologen</string>
  <string>Internistes hématologues,Internisten hematologen</string>
  <string>Internistes intensivistes,Internisten intensivisten</string>
  <string>Internistes urgentistes,Internisten urgentisten</string>
  <string>Internistes oncologues,Internisten oncologen</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection InternalNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["InternalNames"]));
            }
        }
    }
}
