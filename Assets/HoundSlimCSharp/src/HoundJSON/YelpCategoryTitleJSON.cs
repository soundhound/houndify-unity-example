/* file "YelpCategoryTitleJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class YelpCategoryTitleJSON : JSONBase
  {
    private bool flagHasValue;
    private string storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of YelpCategoryTitleJSON is not a string.");
        setValue(json_string.getData());
      }


    public YelpCategoryTitleJSON()
      {
        flagHasValue = false;
      }

    public YelpCategoryTitleJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public string  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void setValue(string new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.string_value(storeValue);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.string_value(storeValue);
      }

    public static YelpCategoryTitleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpCategoryTitleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpCategoryTitle", ignore_extras);
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
    public static YelpCategoryTitleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static YelpCategoryTitleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpCategoryTitleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpCategoryTitle", ignore_extras);
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
    public static YelpCategoryTitleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static YelpCategoryTitleJSON from_text(string text, bool ignore_extras)
      {
        YelpCategoryTitleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpCategoryTitle", ignore_extras);
            JSONParse.parse_json_value(text, "Text for YelpCategoryTitleJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static YelpCategoryTitleJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        YelpCategoryTitleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpCategoryTitle", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONStringGenerator
      {
        protected override void handle_result(string  new_value)
          {
            YelpCategoryTitleJSON result = new YelpCategoryTitleJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(YelpCategoryTitleJSON new_result);
        public Generator(bool ignore_extras) : base("Type YelpCategoryTitle")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(YelpCategoryTitleJSON  result)
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
        public YelpCategoryTitleJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(YelpCategoryTitleJSON  result)
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
    protected virtual void handle_result(List<YelpCategoryTitleJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<YelpCategoryTitleJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<YelpCategoryTitleJSON>();
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
    public List<YelpCategoryTitleJSON> value;
  };
  };