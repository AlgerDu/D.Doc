import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzCardModule } from 'ng-zorro-antd/card';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzCheckboxModule } from 'ng-zorro-antd/checkbox';

import { DbDocRoutingModule } from './db-doc-routing.module';
import { DbDocComponent } from './db-doc.component';
import { DbTablesComponent } from './pages/db-tables.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    DbDocRoutingModule,
    NzButtonModule,
    NzGridModule,
    NzCardModule,
    NzTableModule,
    NzCheckboxModule
  ],
  declarations: [
    DbDocComponent,
    DbTablesComponent
  ],
  exports: [DbDocComponent],
  bootstrap: [DbDocComponent]
})
export class DbDocModule { }
