﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.288
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace AS3AP.BenchMark.Generator {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DsRandomData : DataSet {
        
        private RANDOM_DATADataTable tableRANDOM_DATA;
        
        private RANDOM_TENPCTDataTable tableRANDOM_TENPCT;
        
        public DsRandomData() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DsRandomData(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["RANDOM_DATA"] != null)) {
                    this.Tables.Add(new RANDOM_DATADataTable(ds.Tables["RANDOM_DATA"]));
                }
                if ((ds.Tables["RANDOM_TENPCT"] != null)) {
                    this.Tables.Add(new RANDOM_TENPCTDataTable(ds.Tables["RANDOM_TENPCT"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RANDOM_DATADataTable RANDOM_DATA {
            get {
                return this.tableRANDOM_DATA;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RANDOM_TENPCTDataTable RANDOM_TENPCT {
            get {
                return this.tableRANDOM_TENPCT;
            }
        }
        
        public override DataSet Clone() {
            DsRandomData cln = ((DsRandomData)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["RANDOM_DATA"] != null)) {
                this.Tables.Add(new RANDOM_DATADataTable(ds.Tables["RANDOM_DATA"]));
            }
            if ((ds.Tables["RANDOM_TENPCT"] != null)) {
                this.Tables.Add(new RANDOM_TENPCTDataTable(ds.Tables["RANDOM_TENPCT"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableRANDOM_DATA = ((RANDOM_DATADataTable)(this.Tables["RANDOM_DATA"]));
            if ((this.tableRANDOM_DATA != null)) {
                this.tableRANDOM_DATA.InitVars();
            }
            this.tableRANDOM_TENPCT = ((RANDOM_TENPCTDataTable)(this.Tables["RANDOM_TENPCT"]));
            if ((this.tableRANDOM_TENPCT != null)) {
                this.tableRANDOM_TENPCT.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DsRandomData";
            this.Prefix = "";
            this.Namespace = "";
            this.Locale = new System.Globalization.CultureInfo("es-ES");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableRANDOM_DATA = new RANDOM_DATADataTable();
            this.Tables.Add(this.tableRANDOM_DATA);
            this.tableRANDOM_TENPCT = new RANDOM_TENPCTDataTable();
            this.Tables.Add(this.tableRANDOM_TENPCT);
        }
        
        private bool ShouldSerializeRANDOM_DATA() {
            return false;
        }
        
        private bool ShouldSerializeRANDOM_TENPCT() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void RANDOM_DATARowChangeEventHandler(object sender, RANDOM_DATARowChangeEvent e);
        
        public delegate void RANDOM_TENPCTRowChangeEventHandler(object sender, RANDOM_TENPCTRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_DATADataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnRANDOMIZER;
            
            private DataColumn columnSPARSE_KEY;
            
            private DataColumn columnDENSE_KEY;
            
            private DataColumn columnSPARSE_SIGNED;
            
            private DataColumn columnUNIFORM100_DENSE;
            
            private DataColumn columnZIPF10_FLOAT;
            
            private DataColumn columnZIPF100_FLOAT;
            
            private DataColumn columnUNIFORM100_FLOAT;
            
            private DataColumn columnDOUBLE_NORMAL;
            
            private DataColumn columnR10PCT_KEY;
            
            private DataColumn columnCOL_DATE;
            
            private DataColumn columnCOL_CODE;
            
            private DataColumn columnCOL_NAME;
            
            private DataColumn columnCOL_ADDRESS;
            
            internal RANDOM_DATADataTable() : 
                    base("RANDOM_DATA") {
                this.InitClass();
            }
            
            internal RANDOM_DATADataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn RANDOMIZERColumn {
                get {
                    return this.columnRANDOMIZER;
                }
            }
            
            internal DataColumn SPARSE_KEYColumn {
                get {
                    return this.columnSPARSE_KEY;
                }
            }
            
            internal DataColumn DENSE_KEYColumn {
                get {
                    return this.columnDENSE_KEY;
                }
            }
            
            internal DataColumn SPARSE_SIGNEDColumn {
                get {
                    return this.columnSPARSE_SIGNED;
                }
            }
            
            internal DataColumn UNIFORM100_DENSEColumn {
                get {
                    return this.columnUNIFORM100_DENSE;
                }
            }
            
            internal DataColumn ZIPF10_FLOATColumn {
                get {
                    return this.columnZIPF10_FLOAT;
                }
            }
            
            internal DataColumn ZIPF100_FLOATColumn {
                get {
                    return this.columnZIPF100_FLOAT;
                }
            }
            
            internal DataColumn UNIFORM100_FLOATColumn {
                get {
                    return this.columnUNIFORM100_FLOAT;
                }
            }
            
            internal DataColumn DOUBLE_NORMALColumn {
                get {
                    return this.columnDOUBLE_NORMAL;
                }
            }
            
            internal DataColumn R10PCT_KEYColumn {
                get {
                    return this.columnR10PCT_KEY;
                }
            }
            
            internal DataColumn COL_DATEColumn {
                get {
                    return this.columnCOL_DATE;
                }
            }
            
            internal DataColumn COL_CODEColumn {
                get {
                    return this.columnCOL_CODE;
                }
            }
            
            internal DataColumn COL_NAMEColumn {
                get {
                    return this.columnCOL_NAME;
                }
            }
            
            internal DataColumn COL_ADDRESSColumn {
                get {
                    return this.columnCOL_ADDRESS;
                }
            }
            
            public RANDOM_DATARow this[int index] {
                get {
                    return ((RANDOM_DATARow)(this.Rows[index]));
                }
            }
            
            public event RANDOM_DATARowChangeEventHandler RANDOM_DATARowChanged;
            
            public event RANDOM_DATARowChangeEventHandler RANDOM_DATARowChanging;
            
            public event RANDOM_DATARowChangeEventHandler RANDOM_DATARowDeleted;
            
            public event RANDOM_DATARowChangeEventHandler RANDOM_DATARowDeleting;
            
            public void AddRANDOM_DATARow(RANDOM_DATARow row) {
                this.Rows.Add(row);
            }
            
            public RANDOM_DATARow AddRANDOM_DATARow(int RANDOMIZER, int SPARSE_KEY, int DENSE_KEY, int SPARSE_SIGNED, int UNIFORM100_DENSE, System.Single ZIPF10_FLOAT, System.Single ZIPF100_FLOAT, System.Single UNIFORM100_FLOAT, System.Double DOUBLE_NORMAL, int R10PCT_KEY, string COL_DATE, string COL_CODE, string COL_NAME, string COL_ADDRESS) {
                RANDOM_DATARow rowRANDOM_DATARow = ((RANDOM_DATARow)(this.NewRow()));
                rowRANDOM_DATARow.ItemArray = new object[] {
                        RANDOMIZER,
                        SPARSE_KEY,
                        DENSE_KEY,
                        SPARSE_SIGNED,
                        UNIFORM100_DENSE,
                        ZIPF10_FLOAT,
                        ZIPF100_FLOAT,
                        UNIFORM100_FLOAT,
                        DOUBLE_NORMAL,
                        R10PCT_KEY,
                        COL_DATE,
                        COL_CODE,
                        COL_NAME,
                        COL_ADDRESS};
                this.Rows.Add(rowRANDOM_DATARow);
                return rowRANDOM_DATARow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RANDOM_DATADataTable cln = ((RANDOM_DATADataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RANDOM_DATADataTable();
            }
            
            internal void InitVars() {
                this.columnRANDOMIZER = this.Columns["RANDOMIZER"];
                this.columnSPARSE_KEY = this.Columns["SPARSE_KEY"];
                this.columnDENSE_KEY = this.Columns["DENSE_KEY"];
                this.columnSPARSE_SIGNED = this.Columns["SPARSE_SIGNED"];
                this.columnUNIFORM100_DENSE = this.Columns["UNIFORM100_DENSE"];
                this.columnZIPF10_FLOAT = this.Columns["ZIPF10_FLOAT"];
                this.columnZIPF100_FLOAT = this.Columns["ZIPF100_FLOAT"];
                this.columnUNIFORM100_FLOAT = this.Columns["UNIFORM100_FLOAT"];
                this.columnDOUBLE_NORMAL = this.Columns["DOUBLE_NORMAL"];
                this.columnR10PCT_KEY = this.Columns["R10PCT_KEY"];
                this.columnCOL_DATE = this.Columns["COL_DATE"];
                this.columnCOL_CODE = this.Columns["COL_CODE"];
                this.columnCOL_NAME = this.Columns["COL_NAME"];
                this.columnCOL_ADDRESS = this.Columns["COL_ADDRESS"];
            }
            
            private void InitClass() {
                this.columnRANDOMIZER = new DataColumn("RANDOMIZER", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRANDOMIZER);
                this.columnSPARSE_KEY = new DataColumn("SPARSE_KEY", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSPARSE_KEY);
                this.columnDENSE_KEY = new DataColumn("DENSE_KEY", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDENSE_KEY);
                this.columnSPARSE_SIGNED = new DataColumn("SPARSE_SIGNED", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSPARSE_SIGNED);
                this.columnUNIFORM100_DENSE = new DataColumn("UNIFORM100_DENSE", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUNIFORM100_DENSE);
                this.columnZIPF10_FLOAT = new DataColumn("ZIPF10_FLOAT", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnZIPF10_FLOAT);
                this.columnZIPF100_FLOAT = new DataColumn("ZIPF100_FLOAT", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnZIPF100_FLOAT);
                this.columnUNIFORM100_FLOAT = new DataColumn("UNIFORM100_FLOAT", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUNIFORM100_FLOAT);
                this.columnDOUBLE_NORMAL = new DataColumn("DOUBLE_NORMAL", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDOUBLE_NORMAL);
                this.columnR10PCT_KEY = new DataColumn("R10PCT_KEY", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnR10PCT_KEY);
                this.columnCOL_DATE = new DataColumn("COL_DATE", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_DATE);
                this.columnCOL_CODE = new DataColumn("COL_CODE", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_CODE);
                this.columnCOL_NAME = new DataColumn("COL_NAME", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_NAME);
                this.columnCOL_ADDRESS = new DataColumn("COL_ADDRESS", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_ADDRESS);
                this.columnRANDOMIZER.AllowDBNull = false;
                this.columnSPARSE_KEY.AllowDBNull = false;
                this.columnDENSE_KEY.AllowDBNull = false;
                this.columnSPARSE_SIGNED.AllowDBNull = false;
                this.columnUNIFORM100_DENSE.AllowDBNull = false;
                this.columnZIPF10_FLOAT.AllowDBNull = false;
                this.columnZIPF100_FLOAT.AllowDBNull = false;
                this.columnUNIFORM100_FLOAT.AllowDBNull = false;
                this.columnDOUBLE_NORMAL.AllowDBNull = false;
                this.columnR10PCT_KEY.AllowDBNull = false;
                this.columnCOL_DATE.AllowDBNull = false;
                this.columnCOL_DATE.MaxLength = 20;
                this.columnCOL_CODE.AllowDBNull = false;
                this.columnCOL_CODE.MaxLength = 10;
                this.columnCOL_NAME.AllowDBNull = false;
                this.columnCOL_NAME.MaxLength = 20;
                this.columnCOL_ADDRESS.AllowDBNull = false;
                this.columnCOL_ADDRESS.MaxLength = 80;
            }
            
            public RANDOM_DATARow NewRANDOM_DATARow() {
                return ((RANDOM_DATARow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RANDOM_DATARow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RANDOM_DATARow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RANDOM_DATARowChanged != null)) {
                    this.RANDOM_DATARowChanged(this, new RANDOM_DATARowChangeEvent(((RANDOM_DATARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RANDOM_DATARowChanging != null)) {
                    this.RANDOM_DATARowChanging(this, new RANDOM_DATARowChangeEvent(((RANDOM_DATARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RANDOM_DATARowDeleted != null)) {
                    this.RANDOM_DATARowDeleted(this, new RANDOM_DATARowChangeEvent(((RANDOM_DATARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RANDOM_DATARowDeleting != null)) {
                    this.RANDOM_DATARowDeleting(this, new RANDOM_DATARowChangeEvent(((RANDOM_DATARow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRANDOM_DATARow(RANDOM_DATARow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_DATARow : DataRow {
            
            private RANDOM_DATADataTable tableRANDOM_DATA;
            
            internal RANDOM_DATARow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRANDOM_DATA = ((RANDOM_DATADataTable)(this.Table));
            }
            
            public int RANDOMIZER {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.RANDOMIZERColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.RANDOMIZERColumn] = value;
                }
            }
            
            public int SPARSE_KEY {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.SPARSE_KEYColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.SPARSE_KEYColumn] = value;
                }
            }
            
            public int DENSE_KEY {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.DENSE_KEYColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.DENSE_KEYColumn] = value;
                }
            }
            
            public int SPARSE_SIGNED {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.SPARSE_SIGNEDColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.SPARSE_SIGNEDColumn] = value;
                }
            }
            
            public int UNIFORM100_DENSE {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.UNIFORM100_DENSEColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.UNIFORM100_DENSEColumn] = value;
                }
            }
            
            public System.Single ZIPF10_FLOAT {
                get {
                    return ((System.Single)(this[this.tableRANDOM_DATA.ZIPF10_FLOATColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.ZIPF10_FLOATColumn] = value;
                }
            }
            
            public System.Single ZIPF100_FLOAT {
                get {
                    return ((System.Single)(this[this.tableRANDOM_DATA.ZIPF100_FLOATColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.ZIPF100_FLOATColumn] = value;
                }
            }
            
            public System.Single UNIFORM100_FLOAT {
                get {
                    return ((System.Single)(this[this.tableRANDOM_DATA.UNIFORM100_FLOATColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.UNIFORM100_FLOATColumn] = value;
                }
            }
            
            public System.Double DOUBLE_NORMAL {
                get {
                    return ((System.Double)(this[this.tableRANDOM_DATA.DOUBLE_NORMALColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.DOUBLE_NORMALColumn] = value;
                }
            }
            
            public int R10PCT_KEY {
                get {
                    return ((int)(this[this.tableRANDOM_DATA.R10PCT_KEYColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.R10PCT_KEYColumn] = value;
                }
            }
            
            public string COL_DATE {
                get {
                    return ((string)(this[this.tableRANDOM_DATA.COL_DATEColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.COL_DATEColumn] = value;
                }
            }
            
            public string COL_CODE {
                get {
                    return ((string)(this[this.tableRANDOM_DATA.COL_CODEColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.COL_CODEColumn] = value;
                }
            }
            
            public string COL_NAME {
                get {
                    return ((string)(this[this.tableRANDOM_DATA.COL_NAMEColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.COL_NAMEColumn] = value;
                }
            }
            
            public string COL_ADDRESS {
                get {
                    return ((string)(this[this.tableRANDOM_DATA.COL_ADDRESSColumn]));
                }
                set {
                    this[this.tableRANDOM_DATA.COL_ADDRESSColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_DATARowChangeEvent : EventArgs {
            
            private RANDOM_DATARow eventRow;
            
            private DataRowAction eventAction;
            
            public RANDOM_DATARowChangeEvent(RANDOM_DATARow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RANDOM_DATARow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_TENPCTDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCOL_KEY;
            
            private DataColumn columnCOL_FLOAT;
            
            private DataColumn columnCOL_SIGNED;
            
            private DataColumn columnCOL_DOUBLE;
            
            private DataColumn columnCOL_ADDRESS;
            
            internal RANDOM_TENPCTDataTable() : 
                    base("RANDOM_TENPCT") {
                this.InitClass();
            }
            
            internal RANDOM_TENPCTDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn COL_KEYColumn {
                get {
                    return this.columnCOL_KEY;
                }
            }
            
            internal DataColumn COL_FLOATColumn {
                get {
                    return this.columnCOL_FLOAT;
                }
            }
            
            internal DataColumn COL_SIGNEDColumn {
                get {
                    return this.columnCOL_SIGNED;
                }
            }
            
            internal DataColumn COL_DOUBLEColumn {
                get {
                    return this.columnCOL_DOUBLE;
                }
            }
            
            internal DataColumn COL_ADDRESSColumn {
                get {
                    return this.columnCOL_ADDRESS;
                }
            }
            
            public RANDOM_TENPCTRow this[int index] {
                get {
                    return ((RANDOM_TENPCTRow)(this.Rows[index]));
                }
            }
            
            public event RANDOM_TENPCTRowChangeEventHandler RANDOM_TENPCTRowChanged;
            
            public event RANDOM_TENPCTRowChangeEventHandler RANDOM_TENPCTRowChanging;
            
            public event RANDOM_TENPCTRowChangeEventHandler RANDOM_TENPCTRowDeleted;
            
            public event RANDOM_TENPCTRowChangeEventHandler RANDOM_TENPCTRowDeleting;
            
            public void AddRANDOM_TENPCTRow(RANDOM_TENPCTRow row) {
                this.Rows.Add(row);
            }
            
            public RANDOM_TENPCTRow AddRANDOM_TENPCTRow(int COL_KEY, System.Single COL_FLOAT, int COL_SIGNED, System.Double COL_DOUBLE, string COL_ADDRESS) {
                RANDOM_TENPCTRow rowRANDOM_TENPCTRow = ((RANDOM_TENPCTRow)(this.NewRow()));
                rowRANDOM_TENPCTRow.ItemArray = new object[] {
                        COL_KEY,
                        COL_FLOAT,
                        COL_SIGNED,
                        COL_DOUBLE,
                        COL_ADDRESS};
                this.Rows.Add(rowRANDOM_TENPCTRow);
                return rowRANDOM_TENPCTRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RANDOM_TENPCTDataTable cln = ((RANDOM_TENPCTDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RANDOM_TENPCTDataTable();
            }
            
            internal void InitVars() {
                this.columnCOL_KEY = this.Columns["COL_KEY"];
                this.columnCOL_FLOAT = this.Columns["COL_FLOAT"];
                this.columnCOL_SIGNED = this.Columns["COL_SIGNED"];
                this.columnCOL_DOUBLE = this.Columns["COL_DOUBLE"];
                this.columnCOL_ADDRESS = this.Columns["COL_ADDRESS"];
            }
            
            private void InitClass() {
                this.columnCOL_KEY = new DataColumn("COL_KEY", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_KEY);
                this.columnCOL_FLOAT = new DataColumn("COL_FLOAT", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_FLOAT);
                this.columnCOL_SIGNED = new DataColumn("COL_SIGNED", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_SIGNED);
                this.columnCOL_DOUBLE = new DataColumn("COL_DOUBLE", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_DOUBLE);
                this.columnCOL_ADDRESS = new DataColumn("COL_ADDRESS", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_ADDRESS);
                this.columnCOL_KEY.AllowDBNull = false;
                this.columnCOL_FLOAT.AllowDBNull = false;
                this.columnCOL_SIGNED.AllowDBNull = false;
                this.columnCOL_DOUBLE.AllowDBNull = false;
                this.columnCOL_ADDRESS.AllowDBNull = false;
                this.columnCOL_ADDRESS.MaxLength = 80;
            }
            
            public RANDOM_TENPCTRow NewRANDOM_TENPCTRow() {
                return ((RANDOM_TENPCTRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RANDOM_TENPCTRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RANDOM_TENPCTRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RANDOM_TENPCTRowChanged != null)) {
                    this.RANDOM_TENPCTRowChanged(this, new RANDOM_TENPCTRowChangeEvent(((RANDOM_TENPCTRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RANDOM_TENPCTRowChanging != null)) {
                    this.RANDOM_TENPCTRowChanging(this, new RANDOM_TENPCTRowChangeEvent(((RANDOM_TENPCTRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RANDOM_TENPCTRowDeleted != null)) {
                    this.RANDOM_TENPCTRowDeleted(this, new RANDOM_TENPCTRowChangeEvent(((RANDOM_TENPCTRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RANDOM_TENPCTRowDeleting != null)) {
                    this.RANDOM_TENPCTRowDeleting(this, new RANDOM_TENPCTRowChangeEvent(((RANDOM_TENPCTRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRANDOM_TENPCTRow(RANDOM_TENPCTRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_TENPCTRow : DataRow {
            
            private RANDOM_TENPCTDataTable tableRANDOM_TENPCT;
            
            internal RANDOM_TENPCTRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRANDOM_TENPCT = ((RANDOM_TENPCTDataTable)(this.Table));
            }
            
            public int COL_KEY {
                get {
                    return ((int)(this[this.tableRANDOM_TENPCT.COL_KEYColumn]));
                }
                set {
                    this[this.tableRANDOM_TENPCT.COL_KEYColumn] = value;
                }
            }
            
            public System.Single COL_FLOAT {
                get {
                    return ((System.Single)(this[this.tableRANDOM_TENPCT.COL_FLOATColumn]));
                }
                set {
                    this[this.tableRANDOM_TENPCT.COL_FLOATColumn] = value;
                }
            }
            
            public int COL_SIGNED {
                get {
                    return ((int)(this[this.tableRANDOM_TENPCT.COL_SIGNEDColumn]));
                }
                set {
                    this[this.tableRANDOM_TENPCT.COL_SIGNEDColumn] = value;
                }
            }
            
            public System.Double COL_DOUBLE {
                get {
                    return ((System.Double)(this[this.tableRANDOM_TENPCT.COL_DOUBLEColumn]));
                }
                set {
                    this[this.tableRANDOM_TENPCT.COL_DOUBLEColumn] = value;
                }
            }
            
            public string COL_ADDRESS {
                get {
                    return ((string)(this[this.tableRANDOM_TENPCT.COL_ADDRESSColumn]));
                }
                set {
                    this[this.tableRANDOM_TENPCT.COL_ADDRESSColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RANDOM_TENPCTRowChangeEvent : EventArgs {
            
            private RANDOM_TENPCTRow eventRow;
            
            private DataRowAction eventAction;
            
            public RANDOM_TENPCTRowChangeEvent(RANDOM_TENPCTRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RANDOM_TENPCTRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
