//
// AS3AP Data file Generator
//
// Author: Carlos Guzm�n �lvarez <carlosga@telefonica.net>
//
// Distributable under GPL license.
// You may obtain a copy of the License at http://www.gnu.org/copyleft/gpl.html
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// LGPL License for more details.
//
// This file was created by members of the Firebird development team.
// All individual contributions remain the Copyright (C) of those
// individuals.  Contributors to this file are either listed here or
// can be obtained from a CVS history command.
//
// (c) 2003. All rights reserved.
//
// For more information please see http://www.firebirdsql.org
//

namespace AS3AP.BenchMark.Generator 
{
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DsRandomData : DataSet {
        
        private _TableDataTable table_Table;
        
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
                    this.Tables.Add(new _TableDataTable(ds.Tables["RANDOM_DATA"]));
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
        public _TableDataTable _Table {
            get {
                return this.table_Table;
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
                this.Tables.Add(new _TableDataTable(ds.Tables["RANDOM_DATA"]));
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
            this.table_Table = ((_TableDataTable)(this.Tables["RANDOM_DATA"]));
            if ((this.table_Table != null)) {
                this.table_Table.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "RANDOM_DATA";
            this.Prefix = "";
            this.Namespace = "";
            this.Locale = new System.Globalization.CultureInfo("es-ES");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.table_Table = new _TableDataTable();
            this.Tables.Add(this.table_Table);
        }
        
        private bool ShouldSerialize_Table() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void _TableRowChangeEventHandler(object sender, _TableRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableDataTable : DataTable, System.Collections.IEnumerable {
            
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
            
            private DataColumn columnCODE;
            
            private DataColumn columnNAME;
            
            private DataColumn columnADDRESS;
            
            internal _TableDataTable() : 
                    base("RANDOM_DATA") {
                this.InitClass();
            }
            
            internal _TableDataTable(DataTable table) : 
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
            
            internal DataColumn CODEColumn {
                get {
                    return this.columnCODE;
                }
            }
            
            internal DataColumn NAMEColumn {
                get {
                    return this.columnNAME;
                }
            }
            
            internal DataColumn ADDRESSColumn {
                get {
                    return this.columnADDRESS;
                }
            }
            
            public _TableRow this[int index] {
                get {
                    return ((_TableRow)(this.Rows[index]));
                }
            }
            
            public event _TableRowChangeEventHandler _TableRowChanged;
            
            public event _TableRowChangeEventHandler _TableRowChanging;
            
            public event _TableRowChangeEventHandler _TableRowDeleted;
            
            public event _TableRowChangeEventHandler _TableRowDeleting;
            
            public void Add_TableRow(_TableRow row) {
                this.Rows.Add(row);
            }
            
            public _TableRow Add_TableRow(int RANDOMIZER, int SPARSE_KEY, int DENSE_KEY, int SPARSE_SIGNED, int UNIFORM100_DENSE, System.Single ZIPF10_FLOAT, System.Single ZIPF100_FLOAT, System.Single UNIFORM100_FLOAT, System.Double DOUBLE_NORMAL, int R10PCT_KEY, System.DateTime COL_DATE, string CODE, string NAME, string ADDRESS) {
                _TableRow row_TableRow = ((_TableRow)(this.NewRow()));
                row_TableRow.ItemArray = new object[] {
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
                        CODE,
                        NAME,
                        ADDRESS};
                this.Rows.Add(row_TableRow);
                return row_TableRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                _TableDataTable cln = ((_TableDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new _TableDataTable();
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
                this.columnCODE = this.Columns["CODE"];
                this.columnNAME = this.Columns["NAME"];
                this.columnADDRESS = this.Columns["ADDRESS"];
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
                this.columnCOL_DATE = new DataColumn("COL_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCOL_DATE);
                this.columnCODE = new DataColumn("CODE", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCODE);
                this.columnNAME = new DataColumn("NAME", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNAME);
                this.columnADDRESS = new DataColumn("ADDRESS", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnADDRESS);
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
                this.columnCODE.AllowDBNull = false;
                this.columnCODE.MaxLength = 10;
                this.columnNAME.AllowDBNull = false;
                this.columnNAME.MaxLength = 20;
                this.columnADDRESS.AllowDBNull = false;
                this.columnADDRESS.MaxLength = 800;
            }
            
            public _TableRow New_TableRow() {
                return ((_TableRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new _TableRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(_TableRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this._TableRowChanged != null)) {
                    this._TableRowChanged(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this._TableRowChanging != null)) {
                    this._TableRowChanging(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this._TableRowDeleted != null)) {
                    this._TableRowDeleted(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this._TableRowDeleting != null)) {
                    this._TableRowDeleting(this, new _TableRowChangeEvent(((_TableRow)(e.Row)), e.Action));
                }
            }
            
            public void Remove_TableRow(_TableRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableRow : DataRow {
            
            private _TableDataTable table_Table;
            
            internal _TableRow(DataRowBuilder rb) : 
                    base(rb) {
                this.table_Table = ((_TableDataTable)(this.Table));
            }
            
            public int RANDOMIZER {
                get {
                    return ((int)(this[this.table_Table.RANDOMIZERColumn]));
                }
                set {
                    this[this.table_Table.RANDOMIZERColumn] = value;
                }
            }
            
            public int SPARSE_KEY {
                get {
                    return ((int)(this[this.table_Table.SPARSE_KEYColumn]));
                }
                set {
                    this[this.table_Table.SPARSE_KEYColumn] = value;
                }
            }
            
            public int DENSE_KEY {
                get {
                    return ((int)(this[this.table_Table.DENSE_KEYColumn]));
                }
                set {
                    this[this.table_Table.DENSE_KEYColumn] = value;
                }
            }
            
            public int SPARSE_SIGNED {
                get {
                    return ((int)(this[this.table_Table.SPARSE_SIGNEDColumn]));
                }
                set {
                    this[this.table_Table.SPARSE_SIGNEDColumn] = value;
                }
            }
            
            public int UNIFORM100_DENSE {
                get {
                    return ((int)(this[this.table_Table.UNIFORM100_DENSEColumn]));
                }
                set {
                    this[this.table_Table.UNIFORM100_DENSEColumn] = value;
                }
            }
            
            public System.Double ZIPF10_FLOAT {
                get {
                    return ((System.Single)(this[this.table_Table.ZIPF10_FLOATColumn]));
                }
                set {
                    this[this.table_Table.ZIPF10_FLOATColumn] = value;
                }
            }
            
            public System.Double ZIPF100_FLOAT {
                get {
                    return ((System.Single)(this[this.table_Table.ZIPF100_FLOATColumn]));
                }
                set {
                    this[this.table_Table.ZIPF100_FLOATColumn] = value;
                }
            }
            
            public System.Double UNIFORM100_FLOAT {
                get {
                    return ((System.Single)(this[this.table_Table.UNIFORM100_FLOATColumn]));
                }
                set {
                    this[this.table_Table.UNIFORM100_FLOATColumn] = value;
                }
            }
            
            public System.Double DOUBLE_NORMAL {
                get {
                    return ((System.Double)(this[this.table_Table.DOUBLE_NORMALColumn]));
                }
                set {
                    this[this.table_Table.DOUBLE_NORMALColumn] = value;
                }
            }
            
            public int R10PCT_KEY {
                get {
                    return ((int)(this[this.table_Table.R10PCT_KEYColumn]));
                }
                set {
                    this[this.table_Table.R10PCT_KEYColumn] = value;
                }
            }
            
            public System.DateTime COL_DATE {
                get {
                    return ((System.DateTime)(this[this.table_Table.COL_DATEColumn]));
                }
                set {
                    this[this.table_Table.COL_DATEColumn] = value;
                }
            }
            
            public string CODE {
                get {
                    return ((string)(this[this.table_Table.CODEColumn]));
                }
                set {
                    this[this.table_Table.CODEColumn] = value;
                }
            }
            
            public string NAME {
                get {
                    return ((string)(this[this.table_Table.NAMEColumn]));
                }
                set {
                    this[this.table_Table.NAMEColumn] = value;
                }
            }
            
            public string ADDRESS {
                get {
                    return ((string)(this[this.table_Table.ADDRESSColumn]));
                }
                set {
                    this[this.table_Table.ADDRESSColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class _TableRowChangeEvent : EventArgs {
            
            private _TableRow eventRow;
            
            private DataRowAction eventAction;
            
            public _TableRowChangeEvent(_TableRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public _TableRow Row {
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
