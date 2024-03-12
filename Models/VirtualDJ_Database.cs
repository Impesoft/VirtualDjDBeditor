namespace VirtualDjDBeditor.Models;


using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot(ElementName = "VirtualDJ_Database")]
public class VirtualDJDatabase
{
    [XmlAttribute(AttributeName = "Version")]
    public string Version { get; set; }

    [XmlElement(ElementName = "Song")]
    public List<Song> Songs { get; set; }
}

public class Song
{
    public int Index { get; set; } // added later

    [XmlElement(ElementName = "Tags")]
    public Tags Tags { get; set; }

    [XmlElement(ElementName = "Infos")]
    public Infos Infos { get; set; }

    [XmlElement(ElementName = "Comment")]
    public string Comment { get; set; }

    [XmlElement(ElementName = "Scan")]
    public Scan Scan { get; set; }

    [XmlElement(ElementName = "Poi")]
    public List<Poi> Poi { get; set; }

    [XmlAttribute(AttributeName = "FilePath")]
    public string FilePath { get; set; }

    [XmlAttribute(AttributeName = "FileSize")]
    public string FileSize { get; set; }

    [XmlAttribute(AttributeName = "Flag")]
    public string Flag { get; set; }
}

public class Tags
{
    [XmlAttribute(AttributeName = "Author")]
    public string Author { get; set; }

    [XmlAttribute(AttributeName = "Title")]
    public string Title { get; set; }

    [XmlAttribute(AttributeName = "Genre")]
    public string Genre { get; set; }

    [XmlAttribute(AttributeName = "Composer")]
    public string Composer { get; set; }

    [XmlAttribute(AttributeName = "Remix")]
    public string Remix { get; set; }

    [XmlAttribute(AttributeName = "Grouping")]
    public string Grouping { get; set; }

    [XmlAttribute(AttributeName = "Year")]
    public string Year { get; set; }

    [XmlAttribute(AttributeName = "Bpm")]
    public string Bpm { get; set; }

    [XmlAttribute(AttributeName = "Flag")]
    public string TagFlag { get; set; }
}

public class Infos
{
    [XmlAttribute(AttributeName = "SongLength")]
    public string SongLength { get; set; }

    [XmlAttribute(AttributeName = "LastModified")]
    public string LastModified { get; set; }

    [XmlAttribute(AttributeName = "FirstSeen")]
    public string FirstSeen { get; set; }

    [XmlAttribute(AttributeName = "Bitrate")]
    public string Bitrate { get; set; }

    [XmlAttribute(AttributeName = "Cover")]
    public string Cover { get; set; }
}

public class Scan
{
    [XmlAttribute(AttributeName = "Version")]
    public string Version { get; set; }

    [XmlAttribute(AttributeName = "Bpm")]
    public string Bpm { get; set; }

    [XmlAttribute(AttributeName = "AltBpm")]
    public string AltBpm { get; set; }

    [XmlAttribute(AttributeName = "Volume")]
    public string Volume { get; set; }

    [XmlAttribute(AttributeName = "Key")]
    public string Key { get; set; }

    [XmlAttribute(AttributeName = "Flag")]
    public string ScanFlag { get; set; }
}

public class Poi
{
    [XmlAttribute(AttributeName = "Pos")]
    public string Pos { get; set; }

    [XmlAttribute(AttributeName = "Num")]
    public string Num { get; set; }

    [XmlAttribute(AttributeName = "Color")]
    public string Color { get; set; }

    [XmlAttribute(AttributeName = "Type")]
    public string Type { get; set; }

    [XmlAttribute(AttributeName = "Point")]
    public string Point { get; set; }

    [XmlAttribute(AttributeName = "Name")]
    public string Name { get; set; }
}
