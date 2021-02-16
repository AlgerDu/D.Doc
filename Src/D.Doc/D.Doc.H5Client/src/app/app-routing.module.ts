import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DbDocComponent } from './pages/db-doc/db-doc.component';
import { DbDocModule } from './plugs/db-doc/db-doc.module';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/db' },
  { path: 'db', loadChildren: () => import('./plugs/db-doc/db-doc.module').then(m => m.DbDocModule) },
  { path: 'welcome', loadChildren: () => import('./pages/welcome/welcome.module').then(m => m.WelcomeModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
