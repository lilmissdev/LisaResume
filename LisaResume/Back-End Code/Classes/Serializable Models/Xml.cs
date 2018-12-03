
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class root
{

    private rootRootOfJson rootOfJsonField;

    /// <remarks/>
    public rootRootOfJson rootOfJson
    {
        get
        {
            return this.rootOfJsonField;
        }
        set
        {
            this.rootOfJsonField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJson
{

    private rootRootOfJsonAwards awardsField;

    private rootRootOfJsonBasics basicsField;

    private rootRootOfJsonEducation educationField;

    private rootRootOfJsonInterests interestsField;

    private rootRootOfJsonLanguages languagesField;

    private rootRootOfJsonPublications publicationsField;

    private rootRootOfJsonReferences referencesField;

    private rootRootOfJsonSkills skillsField;

    private rootRootOfJsonVolunteer volunteerField;

    private rootRootOfJsonWork workField;

    /// <remarks/>
    public rootRootOfJsonAwards awards
    {
        get
        {
            return this.awardsField;
        }
        set
        {
            this.awardsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonBasics basics
    {
        get
        {
            return this.basicsField;
        }
        set
        {
            this.basicsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonEducation education
    {
        get
        {
            return this.educationField;
        }
        set
        {
            this.educationField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonInterests interests
    {
        get
        {
            return this.interestsField;
        }
        set
        {
            this.interestsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonLanguages languages
    {
        get
        {
            return this.languagesField;
        }
        set
        {
            this.languagesField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonPublications publications
    {
        get
        {
            return this.publicationsField;
        }
        set
        {
            this.publicationsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonReferences references
    {
        get
        {
            return this.referencesField;
        }
        set
        {
            this.referencesField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonSkills skills
    {
        get
        {
            return this.skillsField;
        }
        set
        {
            this.skillsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonVolunteer volunteer
    {
        get
        {
            return this.volunteerField;
        }
        set
        {
            this.volunteerField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonWork work
    {
        get
        {
            return this.workField;
        }
        set
        {
            this.workField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonAwards
{

    private rootRootOfJsonAwardsElement elementField;

    /// <remarks/>
    public rootRootOfJsonAwardsElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonAwardsElement
{

    private string awarderField;

    private System.DateTime dateField;

    private string summaryField;

    private string titleField;

    /// <remarks/>
    public string awarder
    {
        get
        {
            return this.awarderField;
        }
        set
        {
            this.awarderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonBasics
{

    private string emailField;

    private string labelField;

    private rootRootOfJsonBasicsLocation locationField;

    private string nameField;

    private string phoneField;

    private object pictureField;

    private rootRootOfJsonBasicsProfiles profilesField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public string label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonBasicsLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }

    /// <remarks/>
    public object picture
    {
        get
        {
            return this.pictureField;
        }
        set
        {
            this.pictureField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonBasicsProfiles profiles
    {
        get
        {
            return this.profilesField;
        }
        set
        {
            this.profilesField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonBasicsLocation
{

    private string addressField;

    private string cityField;

    private string countryCodeField;

    private string postalCodeField;

    private string regionField;

    /// <remarks/>
    public string address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string countryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    public string postalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <remarks/>
    public string region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonBasicsProfiles
{

    private rootRootOfJsonBasicsProfilesElement elementField;

    /// <remarks/>
    public rootRootOfJsonBasicsProfilesElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonBasicsProfilesElement
{

    private string networkField;

    private string urlField;

    private string usernameField;

    /// <remarks/>
    public string network
    {
        get
        {
            return this.networkField;
        }
        set
        {
            this.networkField = value;
        }
    }

    /// <remarks/>
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public string username
    {
        get
        {
            return this.usernameField;
        }
        set
        {
            this.usernameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonEducation
{

    private rootRootOfJsonEducationElement elementField;

    /// <remarks/>
    public rootRootOfJsonEducationElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonEducationElement
{

    private string areaField;

    private rootRootOfJsonEducationElementCourses coursesField;

    private System.DateTime endDateField;

    private decimal gpaField;

    private string institutionField;

    private System.DateTime startDateField;

    private string studyTypeField;

    /// <remarks/>
    public string area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonEducationElementCourses courses
    {
        get
        {
            return this.coursesField;
        }
        set
        {
            this.coursesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public decimal gpa
    {
        get
        {
            return this.gpaField;
        }
        set
        {
            this.gpaField = value;
        }
    }

    /// <remarks/>
    public string institution
    {
        get
        {
            return this.institutionField;
        }
        set
        {
            this.institutionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string studyType
    {
        get
        {
            return this.studyTypeField;
        }
        set
        {
            this.studyTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonEducationElementCourses
{

    private string elementField;

    /// <remarks/>
    public string element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonInterests
{

    private rootRootOfJsonInterestsElement elementField;

    /// <remarks/>
    public rootRootOfJsonInterestsElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonInterestsElement
{

    private string[] keywordsField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] keywords
    {
        get
        {
            return this.keywordsField;
        }
        set
        {
            this.keywordsField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonLanguages
{

    private rootRootOfJsonLanguagesElement elementField;

    /// <remarks/>
    public rootRootOfJsonLanguagesElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonLanguagesElement
{

    private string fluencyField;

    private string languageField;

    /// <remarks/>
    public string fluency
    {
        get
        {
            return this.fluencyField;
        }
        set
        {
            this.fluencyField = value;
        }
    }

    /// <remarks/>
    public string language
    {
        get
        {
            return this.languageField;
        }
        set
        {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonPublications
{

    private rootRootOfJsonPublicationsElement elementField;

    /// <remarks/>
    public rootRootOfJsonPublicationsElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonPublicationsElement
{

    private string nameField;

    private string publisherField;

    private System.DateTime releaseDateField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string publisher
    {
        get
        {
            return this.publisherField;
        }
        set
        {
            this.publisherField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime releaseDate
    {
        get
        {
            return this.releaseDateField;
        }
        set
        {
            this.releaseDateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonReferences
{

    private rootRootOfJsonReferencesElement elementField;

    /// <remarks/>
    public rootRootOfJsonReferencesElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonReferencesElement
{

    private string nameField;

    private string referenceField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonSkills
{

    private rootRootOfJsonSkillsElement elementField;

    /// <remarks/>
    public rootRootOfJsonSkillsElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonSkillsElement
{

    private string[] keywordsField;

    private string levelField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] keywords
    {
        get
        {
            return this.keywordsField;
        }
        set
        {
            this.keywordsField = value;
        }
    }

    /// <remarks/>
    public string level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonVolunteer
{

    private rootRootOfJsonVolunteerElement elementField;

    /// <remarks/>
    public rootRootOfJsonVolunteerElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonVolunteerElement
{

    private System.DateTime endDateField;

    private rootRootOfJsonVolunteerElementHighlights highlightsField;

    private string organizationField;

    private string positionField;

    private System.DateTime startDateField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonVolunteerElementHighlights highlights
    {
        get
        {
            return this.highlightsField;
        }
        set
        {
            this.highlightsField = value;
        }
    }

    /// <remarks/>
    public string organization
    {
        get
        {
            return this.organizationField;
        }
        set
        {
            this.organizationField = value;
        }
    }

    /// <remarks/>
    public string position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonVolunteerElementHighlights
{

    private string elementField;

    /// <remarks/>
    public string element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonWork
{

    private rootRootOfJsonWorkElement elementField;

    /// <remarks/>
    public rootRootOfJsonWorkElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonWorkElement
{

    private string companyField;

    private System.DateTime endDateField;

    private rootRootOfJsonWorkElementHighlights highlightsField;

    private string positionField;

    private System.DateTime startDateField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    public string company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonWorkElementHighlights highlights
    {
        get
        {
            return this.highlightsField;
        }
        set
        {
            this.highlightsField = value;
        }
    }

    /// <remarks/>
    public string position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonWorkElementHighlights
{

    private string elementField;

    /// <remarks/>
    public string element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

