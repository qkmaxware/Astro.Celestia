# Astro.Celestia
Qkmaxware.Astro.Celestia contains a catalogue of stars, deep sky objects, and planets. This entire catalogue is stored in memory and not queried via web APIs at runtime. This allows this database to be accessed when internet is not available (like when at a dark sky location).

## Data generation
The Astro.Celestia.Generator project is used to generate the C# catalogue classes using a combination of downloaded data files and web APIs. This should be updated and run before publishing new nuget packages.

## Example Usage(s)
Fetching all Messier objects from the New General Catalogue of deep sky objects
```cs
DeepSkyObjectCatalogue.NGC.Where(obj => obj.SecondaryIdentifiers.ContainsKey("Messier")).OrderBy(obj => obj.SecondaryIdentifiers["Messier"]);
```
Fetching all stars with a given brightness range
```cs
double minMagnitude = ...;
double maxMagnitude = ...;
StarCatalogue.Hipparcos.Where(obj => obj.VisualMagnitude.HasValue && obj.VisualMagnitude.Value >= minMagnitude && obj.VisualMagnitude.Value <= maxMagnitude);
```
Ordering the planets in the solar system by mass
```cs
PlanetCatalogue.SolSystemAtJ2000.OrderBy(planet => planet.Mass);
```