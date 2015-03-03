﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("map")]
public class Map {
    [XmlElement("tileset")]
    public List<TileSet> tilesets = new List<TileSet>();
    [XmlElement("layer")]
    public List<Layer> layers = new List<Layer>();
}

// START TileSet Classes //

public class TileSet {
	[XmlAttribute("firstgid")]
    public int firstgid;
	[XmlAttribute("name")]
    public string name;

	[XmlElement("tile")]
    public List<TileSetTile> tiles = new List<TileSetTile>();
}

public class TileSetTile {
	[XmlAttribute("id")]
    public int id;
	// You're right, this is a strange name for an element. But it's a pointless element like <data> (see layer classes)
	// and it's even more confusing 
	/*
	[XmlElement("properties")]
	public TileSetProperties[] propertyContainer;
	*/
	[XmlElement("properties")]
	public TileSetProperties properties;
}

public class TileSetProperties{
	[XmlElement("property")]
	public TileSetProperty[] propertyList;
}

public class TileSetProperty {
	[XmlAttribute("name")]
	public string name;
	[XmlAttribute("value")]
    public string value;
}

// END TileSet Classes //



// START Layer Classes //

public class Layer{
    [XmlAttribute("width")]
	public int width;
    [XmlAttribute("height")]
	public int height;
    [XmlAttribute("name")]
	public string name;

    // This TileList contains the random data element that actually contains the data titles. 
	// It makes for weird looking foreach() statements, but it works!
    [XmlElement("data")]
    public LayerTileList data;
}

public class LayerTileList{
    [XmlElement("tile")]
    public LayerTile[] tiles;
}

public class LayerTile {
	[XmlAttribute("gid")]
	public int gid;
}

// END Layer Classes //