# SoMLib

Unity utility package with Event System and Tools.

## Installation

### Via Package Manager (Git URL)
```
https://github.com/thisis72/SoMLib-Package.git#0.1.0
```

### Via manifest.json
Add to `Packages/manifest.json`:
```json
{
  "dependencies": {
    "com.thisis72.somlib": "https://github.com/thisis72/SoMLib-Package.git#0.1.0"
  }
}
```

## Features

### Event System
- **SoMFixedEvent**: ScriptableObject-based event with fixed struct (int, Vector3, string, GameObject)
- **SoMStringEvent**: Dynamic string payload events with key=value parsing
- **StringBuilder Pooling**: Reduces GC allocation
- **Inspector Integration**: View registered listeners in real-time

### Tools
- **TestLog**: Simple logging utilities

## Usage

### Event System
```csharp
using SoMLib.Event;

// Create event asset (Right-click → Create → SoMLib → Event)
public SoMFixedEvent myEvent;

// Raise event
myEvent.Raise(new SoMFixedEventData { 
    intValue = 10, 
    stringValue = "Hello" 
});

// String event with builder
string payload = SoMStringEventHelper.Create()
    .Add("type", "damage")
    .Add("value", 25)
    .Build();
myStringEvent.Raise(payload);
```

### Tools
```csharp
using SoMLib.Tools;

TestLog.Llog("Debug message");
```

## Samples
Import samples via Package Manager → SoMLib → Samples → Basic Event System

## Requirements
- Unity 2021.3 or later

## License
MIT
