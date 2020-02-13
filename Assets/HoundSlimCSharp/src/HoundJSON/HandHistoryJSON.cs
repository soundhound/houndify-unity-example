/* file "HandHistoryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HandHistoryJSON : JSONBase
  {
    private bool flagHasLastDateAndOrTime;
    private DateAndOrTimeJSON  storeLastDateAndOrTime;
    private bool flagHasNumberOfPlayerCards;
    private sbyte storeNumberOfPlayerCards;
    private bool flagHasBetAmount;
    private double storeBetAmount;
    private string textStoreBetAmount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLastDateAndOrTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setLastDateAndOrTime(convert_classy);
      }


    private void  fromJSONNumberOfPlayerCards(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumberOfPlayerCards of HandHistoryJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumberOfPlayerCards of HandHistoryJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setNumberOfPlayerCards(extracted_integer);
      }


    private void  fromJSONBetAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field BetAmount of HandHistoryJSON is not a number.");
              }
          }
        setBetAmountText(the_rational_text);
      }


    public HandHistoryJSON()
      {
        flagHasLastDateAndOrTime = false;
        flagHasNumberOfPlayerCards = false;
        flagHasBetAmount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLastDateAndOrTime()
      {
        return flagHasLastDateAndOrTime;
      }

    public DateAndOrTimeJSON   getLastDateAndOrTime()
      {
        Debug.Assert(flagHasLastDateAndOrTime);
        return storeLastDateAndOrTime;
      }

    public bool  hasNumberOfPlayerCards()
      {
        return flagHasNumberOfPlayerCards;
      }

    public sbyte  getNumberOfPlayerCards()
      {
        Debug.Assert(flagHasNumberOfPlayerCards);
        return storeNumberOfPlayerCards;
      }

    public bool  hasBetAmount()
      {
        return flagHasBetAmount;
      }

    public double  getBetAmount()
      {
        Debug.Assert(flagHasBetAmount);
        if (textStoreBetAmount != "")
          {
            return Double.Parse(textStoreBetAmount);
          }
        return storeBetAmount;
      }

    public string  getBetAmountAsText()
      {
        Debug.Assert(flagHasBetAmount);
        if (textStoreBetAmount == "")
          {
            return Convert.ToString(storeBetAmount);
          }
        else
          {
            return (textStoreBetAmount);
          }
      }


    public virtual int extraHandHistoryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHandHistoryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHandHistoryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHandHistoryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLastDateAndOrTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasLastDateAndOrTime)
          {
          }
        flagHasLastDateAndOrTime = true;
        storeLastDateAndOrTime = new_value;
      }
    public void unsetLastDateAndOrTime()
      {
        if (flagHasLastDateAndOrTime)
          {
          }
        flagHasLastDateAndOrTime = false;
      }
    public void setNumberOfPlayerCards(sbyte new_value)
      {
        flagHasNumberOfPlayerCards = true;
        if (new_value < 2)
            throw new Exception("The value for field NumberOfPlayerCards of HandHistoryJSON is less than the lower bound (2) for that field.");
        if (new_value > 11)
            throw new Exception("The value for field NumberOfPlayerCards of HandHistoryJSON is greater than the upper bound (11) for that field.");
        storeNumberOfPlayerCards = new_value;
      }
    public void unsetNumberOfPlayerCards()
      {
        flagHasNumberOfPlayerCards = false;
      }
    public void setBetAmount(double new_value)
      {
        flagHasBetAmount = true;
        storeBetAmount = new_value;
        textStoreBetAmount = "";
      }
    public void setBetAmountText(string new_value)
      {
        flagHasBetAmount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BetAmount of HandHistoryJSON is not a valid number.");
        textStoreBetAmount = new_value;
      }
    public void unsetBetAmount()
      {
        flagHasBetAmount = false;
      }

    public virtual void extraHandHistoryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHandHistorySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHandHistoryLookup(key);
        if (old_field == null)
          {
            extraHandHistoryAppendPair(key, new_component);
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
        if (flagHasLastDateAndOrTime)
          {
            handler.start_pair("LastDateAndOrTime");
            if (partial_allowed)
                storeLastDateAndOrTime.write_partial_as_json(handler);
            else
                storeLastDateAndOrTime.write_as_json(handler);
          }
        if (flagHasNumberOfPlayerCards)
          {
            handler.start_pair("NumberOfPlayerCards");
            handler.number_value(storeNumberOfPlayerCards);
          }
        if (flagHasBetAmount)
          {
            handler.start_pair("BetAmount");
            if (textStoreBetAmount != "")
                handler.number_value(textStoreBetAmount);
            else if (((double)(long)storeBetAmount) == storeBetAmount)
                handler.number_value((long)storeBetAmount);
            else
                handler.number_value(storeBetAmount);
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
        return null;
      }

    public static HandHistoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HandHistoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandHistory", ignore_extras);
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
    public static HandHistoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HandHistoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HandHistoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandHistory", ignore_extras);
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
    public static HandHistoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HandHistoryJSON from_text(string text, bool ignore_extras)
      {
        HandHistoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandHistory", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HandHistoryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HandHistoryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HandHistoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandHistory", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorLastDateAndOrTime;
    private class FieldHoldingGeneratorNumberOfPlayerCards : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorNumberOfPlayerCards(String what) : base(what, 2, 11)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumberOfPlayerCards : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumberOfPlayerCards(String what) : base(what, 2, 11)
              {
              }
          };
        private FieldHoldingGeneratorNumberOfPlayerCards fieldGeneratorNumberOfPlayerCards;
        private JSONHoldingNumberTextGenerator fieldGeneratorBetAmount;
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
            HandHistoryJSON result = new HandHistoryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHandHistoryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HandHistoryJSON result)
          {
            if (fieldGeneratorLastDateAndOrTime.have_value)
              {
                result.setLastDateAndOrTime(fieldGeneratorLastDateAndOrTime.value);
                fieldGeneratorLastDateAndOrTime.have_value = false;
              }
            if (fieldGeneratorNumberOfPlayerCards.have_value)
              {
                result.setNumberOfPlayerCards((sbyte)(fieldGeneratorNumberOfPlayerCards.value));
                fieldGeneratorNumberOfPlayerCards.have_value = false;
              }
            if (fieldGeneratorBetAmount.have_value)
              {
                result.setBetAmountText(fieldGeneratorBetAmount.value);
                fieldGeneratorBetAmount.have_value = false;
              }
          }
        protected abstract void handle_result(HandHistoryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "etAmount", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorBetAmount;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astDateAndOrTime", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorLastDateAndOrTime;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umberOfPlayerCards", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorNumberOfPlayerCards;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLastDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"LastDateAndOrTime\" of the HandHistory class", ignore_extras);
            fieldGeneratorNumberOfPlayerCards = new FieldHoldingGeneratorNumberOfPlayerCards("field \"NumberOfPlayerCards\" of the HandHistory class");
            fieldGeneratorBetAmount = new JSONHoldingNumberTextGenerator("field \"BetAmount\" of the HandHistory class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HandHistory class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLastDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"LastDateAndOrTime\" of the HandHistory class", false);
            fieldGeneratorNumberOfPlayerCards = new FieldHoldingGeneratorNumberOfPlayerCards("field \"NumberOfPlayerCards\" of the HandHistory class");
            fieldGeneratorBetAmount = new JSONHoldingNumberTextGenerator("field \"BetAmount\" of the HandHistory class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HandHistory class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLastDateAndOrTime.reset();
            fieldGeneratorNumberOfPlayerCards.reset();
            fieldGeneratorBetAmount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLastDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLastDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HandHistoryJSON  result)
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
        public HandHistoryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HandHistoryJSON  result)
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
    protected virtual void handle_result(List<HandHistoryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HandHistoryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HandHistoryJSON>();
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
    public List<HandHistoryJSON> value;
  };
  };