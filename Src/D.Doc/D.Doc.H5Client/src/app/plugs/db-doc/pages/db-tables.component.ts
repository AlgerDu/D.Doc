import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'db-tables',
  templateUrl: './db-tables.component.html',
  styleUrls: ['./db-tables.component.less']
})
export class DbTablesComponent implements OnInit {

  schemaDatas: DbSchemaData[];
  schemaDateType = DbSchemaType;
  headers = ["ID", "Name", "Age", "Gender", "Country"];

  constructor() {
    this.schemaDatas = [
      {
        isSelect: false,
        type: DbSchemaType.Table,
        data: {
          name: "doc",
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
