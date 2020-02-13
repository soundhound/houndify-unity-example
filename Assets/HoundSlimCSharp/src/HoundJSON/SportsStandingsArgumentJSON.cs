/* file "SportsStandingsArgumentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsStandingsArgumentJSON : JSONBase
  {
    public struct TypeArgumentData
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public SportsStandingsArgumentWildCardJSON  choice0;
            [FieldOffset(0)]
            public SportsSeasonJSON  choice1;
            [FieldOffset(0)]
            public SportsStandingsArgumentConferenceJSON  choice2;
            [FieldOffset(0)]
            public SportsStandingsArgumentDivisionalJSON  choice3;
          };
        public Utype u;
      };
    private bool flagHasArgumentData;
    private TypeArgumentData storeArgumentData;
    private bool flagHasArgumentID;
    private BigInteger storeArgumentID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONArgumentData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeArgumentData or_result = new TypeArgumentData();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                SportsStandingsArgumentWildCardJSON convert_classy = SportsStandingsArgumentWildCardJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                SportsSeasonJSON convert_classy = SportsSeasonJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                SportsStandingsArgumentConferenceJSON convert_classy = SportsStandingsArgumentConferenceJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice2 = convert_classy;
                or_result.key = 2;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                SportsStandingsArgumentDivisionalJSON convert_classy = SportsStandingsArgumentDivisionalJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice3 = convert_classy;
                or_result.key = 3;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ArgumentData of SportsStandingsArgumentJSON is not one of the allowed values.");
        setArgumentData(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONArgumentID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ArgumentID of SportsStandingsArgumentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ArgumentID of SportsStandingsArgumentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setArgumentID(extracted_integer);
      }


    public SportsStandingsArgumentJSON()
      {
        flagHasArgumentData = false;
        flagHasArgumentID = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasArgumentData()
      {
        return flagHasArgumentData;
      }

    public TypeArgumentData  getArgumentData()
      {
        Debug.Assert(flagHasArgumentData);
        return storeArgumentData;
      }

    public bool  hasArgumentID()
      {
        return flagHasArgumentID;
      }

    public BigInteger  getArgumentID()
      {
        Debug.Assert(flagHasArgumentID);
        return storeArgumentID;
      }


    public virtual int extraSportsStandingsArgumentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setArgumentData(TypeArgumentData new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasArgumentData)
          {
            switch (storeArgumentData.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasArgumentData = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeArgumentData = new_value;
      }
    public void unsetArgumentData()
      {
        if (flagHasArgumentData)
          {
            switch (storeArgumentData.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasArgumentData = false;
      }
    public void setArgumentID(BigInteger new_value)
      {
        flagHasArgumentID = true;
        if (new_value < 0)
            throw new Exception("The value for field ArgumentID of SportsStandingsArgumentJSON is less than the lower bound (0) for that field.");
        storeArgumentID = new_value;
      }
    public void unsetArgumentID()
      {
        flagHasArgumentID = false;
      }

    public virtual void extraSportsStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentAppendPair(key, new_component);
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasArgumentData);
        if (flagHasArgumentData)
          {
            handler.start_pair("ArgumentData");
            switch (storeArgumentData.key)
              {
                case 0:
                    if (partial_allowed)
                        storeArgumentData.u.choice0.write_partial_as_json(handler);
                    else
                        storeArgumentData.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    if (partial_allowed)
                        storeArgumentData.u.choice1.write_partial_as_json(handler);
                    else
                        storeArgumentData.u.choice1.write_as_json(handler);
                    break;
                case 2:
                    if (partial_allowed)
                        storeArgumentData.u.choice2.write_partial_as_json(handler);
                    else
                        storeArgumentData.u.choice2.write_as_json(handler);
                    break;
                case 3:
                    if (partial_allowed)
                        storeArgumentData.u.choice3.write_partial_as_json(handler);
                    else
                        storeArgumentData.u.choice3.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasArgumentID);
        if (flagHasArgumentID)
          {
            handler.start_pair("ArgumentID");
            handler.number_value(storeArgumentID);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasArgumentData()))
          {
            return "When parsing the object for %what%, the \"ArgumentData\" field was missing.";
          }
        if (!(hasArgumentID()))
          {
            return "When parsing the object for %what%, the \"ArgumentID\" field was missing.";
          }
        return null;
      }

    public static SportsStandingsArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgument", ignore_extras);
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
    public static SportsStandingsArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgument", ignore_extras);
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
    public static SportsStandingsArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsArgumentJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgument", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsArgumentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgument", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorArgumentData : JSONParallelGenerator
          {
            private SportsStandingsArgumentWildCardJSON.HoldingGenerator field0;
            private SportsSeasonJSON.HoldingGenerator field1;
            private SportsStandingsArgumentConferenceJSON.HoldingGenerator field2;
            private SportsStandingsArgumentDivisionalJSON.HoldingGenerator field3;
            private JSONHandler [] all_handlers = new JSONHandler [4];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeArgumentData result = new TypeArgumentData();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    case 2:
                      {
                        Debug.Assert(field2.have_value);
                        result.u.choice2 = field2.value;
                        break;
                      }
                    case 3:
                      {
                        Debug.Assert(field3.have_value);
                        result.u.choice3 = field3.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeArgumentData result);
            public FieldGeneratorArgumentData(bool ignore_extras)
              {
                    field0 = new SportsStandingsArgumentWildCardJSON.HoldingGenerator("option 0 of field \"ArgumentData\"", ignore_extras);
                    field1 = new SportsSeasonJSON.HoldingGenerator("option 1 of field \"ArgumentData\"", ignore_extras);
                    field2 = new SportsStandingsArgumentConferenceJSON.HoldingGenerator("option 2 of field \"ArgumentData\"", ignore_extras);
                    field3 = new SportsStandingsArgumentDivisionalJSON.HoldingGenerator("option 3 of field \"ArgumentData\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
                all_handlers[3] = field3;
              }
            public FieldGeneratorArgumentData(string what, bool ignore_extras)
              {
                    field0 = new SportsStandingsArgumentWildCardJSON.HoldingGenerator("option 0 of field \"ArgumentData\"", ignore_extras);
                    field1 = new SportsSeasonJSON.HoldingGenerator("option 1 of field \"ArgumentData\"", ignore_extras);
                    field2 = new SportsStandingsArgumentConferenceJSON.HoldingGenerator("option 2 of field \"ArgumentData\"", ignore_extras);
                    field3 = new SportsStandingsArgumentDivisionalJSON.HoldingGenerator("option 3 of field \"ArgumentData\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
                all_handlers[3] = field3;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                field2.reset();
                field3.reset();
                base.reset();
              }
          };
        private class HolderArgumentData
          {
            private bool have_data;
            private TypeArgumentData data;
            public HolderArgumentData()  { have_data = false; }
            public HolderArgumentData(TypeArgumentData init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderArgumentData(HolderArgumentData other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeArgumentData referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorArgumentData : FieldGeneratorArgumentData
          {
            protected override void handle_result(TypeArgumentData result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderArgumentData(result);
              }

            public FieldHoldingGeneratorArgumentData(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderArgumentData value;
          };
    private class FieldHoldingArrayGeneratorArgumentData : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorArgumentData
      {
        private FieldHoldingArrayGeneratorArgumentData top;

        protected override void handle_result(TypeArgumentData result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArgumentData init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeArgumentData> result)
      {
      }

    public FieldHoldingArrayGeneratorArgumentData(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeArgumentData>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArgumentData(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeArgumentData>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeArgumentData> value;
  };
        private FieldHoldingGeneratorArgumentData fieldGeneratorArgumentData;
    private class FieldHoldingGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorArgumentID fieldGeneratorArgumentID;
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

        protected bool allow_incomplete;

        protected bool allow_unpolished;

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
            SportsStandingsArgumentJSON result = new SportsStandingsArgumentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsArgumentJSON result)
          {
            if (fieldGeneratorArgumentData.have_value)
              {
                result.setArgumentData(fieldGeneratorArgumentData.value.referenced());
                fieldGeneratorArgumentData.have_value = false;
              }
            else if ((!(result.hasArgumentData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentData\" field was missing.");
              }
            if (fieldGeneratorArgumentID.have_value)
              {
                result.setArgumentID(fieldGeneratorArgumentID.value);
                fieldGeneratorArgumentID.have_value = false;
              }
            else if ((!(result.hasArgumentID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentID\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsStandingsArgumentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Argument", 0, 8, false) == 0)
              {
                switch (field_name[8])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorArgumentData;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 9, "D", 0, 1, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorArgumentID;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentData = new FieldHoldingGeneratorArgumentData("field \"ArgumentData\" of the SportsStandingsArgument class", ignore_extras);
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsStandingsArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentData = new FieldHoldingGeneratorArgumentData("field \"ArgumentData\" of the SportsStandingsArgument class", false);
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsStandingsArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentData.reset();
            fieldGeneratorArgumentID.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentJSON  result)
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
        public SportsStandingsArgumentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentJSON>();
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
    public List<SportsStandingsArgumentJSON> value;
  };
  };