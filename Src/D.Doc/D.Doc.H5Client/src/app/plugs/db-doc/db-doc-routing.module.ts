import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DbDocComponent } from 'src/app/pages/db-doc/db-doc.component';

import { DbTablesComponent } from './pages/db-tables.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/tables' },
  {
    path: '**',
    component: DbDocComponent,
    children: [
      {
        path: 'tables', // child route path
        component: DbTablesComponent,
      }
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DbDocRoutingModule { }
