using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

public class GoalConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(Goal));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        switch (jo["$type"].Value<string>())
        {
            case "SimpleGoal, Develop05":
                return jo.ToObject<SimpleGoal>(serializer);
            case "EternalGoal, Develop05":
                return jo.ToObject<EternalGoal>(serializer);
            case "ChecklistGoal, Develop05":
                return jo.ToObject<ChecklistGoal>(serializer);
            default:
                throw new Exception("Unknown GoalType");
        }
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        JObject jo = new JObject();
        if (value is SimpleGoal simpleGoal)
        {
            jo.Add("$type", "SimpleGoal, Develop05");
            jo.Merge(JObject.FromObject(simpleGoal, serializer));
        }
        else if (value is EternalGoal eternalGoal)
        {
            jo.Add("$type", "EternalGoal, Develop05");
            jo.Merge(JObject.FromObject(eternalGoal, serializer));
        }
        else if (value is ChecklistGoal checklistGoal)
        {
            jo.Add("$type", "ChecklistGoal, Develop05");
            jo.Merge(JObject.FromObject(checklistGoal, serializer));
        }
        jo.WriteTo(writer);
    }
}
