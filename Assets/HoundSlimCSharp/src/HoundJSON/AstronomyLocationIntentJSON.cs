/* file "AstronomyLocationIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AstronomyLocationIntentJSON : LocationIntentJSON
  {
    private bool flagHasName;
    private string storeName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNameToJSON()
      {
        JSONStringValue generated_string_Name = new JSONStringValue(storeName);
        return generated_string_Name;
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of AstronomyLocationIntentJSON is not a string.");
        setName(json_string.getData());
      }


    public AstronomyLocationIntentJSON()
      {
        flagHasName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getLocationIntentKind()
      {
        return "Astronomy";
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }


    public virtual int extraAstronomyLocationIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAstronomyLocationIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAstronomyLocationIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAstronomyLocationIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraLocationIntentComponentCount()
      {
        int result = 0;
        if (flagHasName)
            ++result;
        result += extraAstronomyLocationIntentComponentCount();
        return result;
      }
    public override string extraLocationIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasName)
          {
            if (remainder == 0)
                return "Name";
            --remainder;
          }
        return extraAstronomyLocationIntentComponentKey(remainder);
      }
    public override JSONValue extraLocationIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasName)
          {
            if (remainder == 0)
                return extraNameToJSON();
            --remainder;
          }
        return extraAstronomyLocationIntentComponentValue(remainder);
      }
    public override JSONValue extraLocationIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Name", 0, 4, false) == 0) && (field_name.Length == 4))
            return (flagHasName ? extraNameToJSON() : null);
        return extraAstronomyLocationIntentLookup(field_name);
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }

    public virtual void extraAstronomyLocationIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAstronomyLocationIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAstronomyLocationIntentLookup(key);
        if (old_field == null)
          {
            extraAstronomyLocationIntentAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }
    public override void extraLocationIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Name", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONName(new_component, false);
            return;
            }
        extraAstronomyLocationIntentAppendPair(key, new_component);
      }
    public override void extraLocationIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Name", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONName(new_component, false);
            return;
            }
        extraAstronomyLocationIntentSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        return null;
      }

    public static new AstronomyLocationIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AstronomyLocationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyLocationIntent", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write(generator);
            else
                json_value.write(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AstronomyLocationIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AstronomyLocationIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AstronomyLocationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyLocationIntent", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write_partial_as_json(generator);
            else
                json_value.write_as_json(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AstronomyLocationIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AstronomyLocationIntentJSON from_text(string text, bool ignore_extras)
      {
        AstronomyLocationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyLocationIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AstronomyLocationIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AstronomyLocationIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AstronomyLocationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyLocationIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : LocationIntentJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getLocationIntentJSONKey().Equals("Astronomy")))
                throw new Exception("The key field has a value other than `Astronomy'.");
            AstronomyLocationIntentJSON result = new AstronomyLocationIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAstronomyLocationIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(LocationIntentJSON new_result)
          {
            handle_result((AstronomyLocationIntentJSON )new_result);
          }
        protected void finish(AstronomyLocationIntentJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(AstronomyLocationIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Name", 0, 4, false) == 0) && (field_name.Length == 4))
                return fieldGeneratorName;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the AstronomyLocationIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AstronomyLocationIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the AstronomyLocationIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AstronomyLocationIntent class");
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AstronomyLocationIntentJSON  result)
          {
//@@@            Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
          {
            have_value = false;
            base.set_what(what);
          }

        public HoldingGenerator(String what) : base(false)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public AstronomyLocationIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AstronomyLocationIntentJSON  result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<AstronomyLocationIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AstronomyLocationIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AstronomyLocationIntentJSON>();
        have_value = false;
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<AstronomyLocationIntentJSON> value;
  };
  };