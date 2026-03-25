using System.Collections.Generic;

/// <summary>
/// FeatureCollection classes to describe USGS earthquake JSON data.
/// These classes map directly to the JSON structure.
/// </summary>
public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public double? Mag { get; set; }
}