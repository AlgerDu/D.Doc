import { NgModule } from '@angular/core';

import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzCardModule } from 'ng-zorro-antd/card';
import { NzTableModule } from 'ng-zorro-antd/table';

import { DbDocRoutingModule } from './db-doc-routing.module';
import { DbDocComponent } from './db-doc.component';
import { DbTablesComponent } from './pages/db-tables.component';

@NgModule({
  imports: [
    DbDocRoutingModule,
    NzButtonModule,
    NzGridModule,
    NzCardModule,
    NzTableModule
  ],
  declarations: [
    DbDocComponent,
    DbTablesComponent
  ],
  exports: [DbDocComponent],
  bootstrap: [DbDocComponent]
})
export class DbDocModule { }
