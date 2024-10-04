using System.Text.Json.Serialization;

namespace HybridWebViewApp.Models;

//[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(int))]
internal partial class IntContext : JsonSerializerContext;
