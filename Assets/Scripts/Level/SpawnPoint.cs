﻿using System.Xml.Serialization;

[XmlType(TypeName = "spawnpoint")]
public class SpawnPoint : MapItem {
    [XmlIgnore]
    public SoftwareTool software;

    [XmlIgnore] public static SpawnPoint Spawn = new SpawnPoint {
        name = "Spawn Point",
        description = "Attack vector entry point for your software tools",
        string_id = "spawnpoint"
    };
}
