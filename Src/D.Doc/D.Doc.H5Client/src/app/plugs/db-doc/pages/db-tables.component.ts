import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'db-tables',
  templateUrl: './db-tables.component.html',
  styleUrls: ['./db-tables.component.less']
})
export class DbTablesComponent implements OnInit {
  selectAll = false;
  schemaDatas: DbSchemaData[];
  schemaDateType = DbSchemaType;
  headers = [{
    key:"name",
    text:"名字"
  },
  {
    key:"ch_name",
    text:"中文名"
  },
  {
    key:"enableNull",
    text:"可空"
  },
  {
    key:"type",
    text:"类型"
  },
  {
    key:"length",
    text:"长度"
  },
  {
    key:"description",
    text:"说明"
  },
  {
    key:"lastUpdateUserName",
    text:"最后修改人"
  },
  {
    key:"lastUpdateTime",
    text:"最后修改时间"
  }
];

  constructor() {
    this.schemaDatas = [
      {
        isSelect: false,
        type: DbSchemaType.Table,
        data: {
          name: "doc",
          ch_name: "文档",
          lastUpdateUserName:"duzw",
          lastUpdateTime:"2021-01-17 09:53"
        }
      },
      {
        isSelect: true,
        type: DbSchemaType.Field,
        data: {
          name: "id",
          ch_name: "",
          type:"long",
          length :"",
          enableNull: false,
          description: "主键",
          lastUpdateUserName:"duzw",
          lastUpdateTime:"2021-01-17 09:53"
        }
      },
      {
        isSelect: false,
        type: DbSchemaType.Field,
        data: {
          name: "name",
          ch_name: "",
          type:"long",
          length :"",
          enableNull: false,
          description: "主键",
          lastUpdateUserName:"duzw",
          lastUpdateTime:"2021-01-17 09:53"
        }
      },
      {
        isSelect: false,
        type: DbSchemaType.Field,
        data: {
          name: "version",
          ch_name: "",
          type:"long",
          length :"",
          enableNull: false,
          description: "主键",
          lastUpdateUserName:"duzw",
          lastUpdateTime:"2021-01-17 09:53"
        }
      },
      {
        isSelect: false,
        type: DbSchemaType.Table,
        data: {
          name: "doc_tree",
          text: "文档"
        }
      },
      {
        isSelect: true,
        type: DbSchemaType.Field,
        data: {
          name: "id",
          text: "",
          enableNull: false,
          description: "主键"
        }
      },
      {
        isSelect: false,
        type: DbSchemaType.Field,
        data: {
          name: "name",
          text: "文档名称",
          enableNull: false,
          description: ""
        }
      },
      {
        isSelect: false,
        type: DbSchemaType.Field,
        data: {
          name: "version",
          text: "版本",
          enableNull: false,
          description: ""
        }
      }
    ]
  }

  ngOnInit(): void {

  }

}

export class DbSchemaData {
  public isSelect: boolean;
  public type: DbSchemaType;
  public data: { [key: string]: any };

  constructor() {
    this.isSelect = false
  }
}

export enum DbSchemaType {
  Table,
  Field
}
