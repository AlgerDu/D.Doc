import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DbDocComponent } from './pages/db-doc/db-doc.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/db' },
  { path: 'db', component: DbDocComponent },
  { path: 'welcome', loadChildren: () => import('./pages/welcome/welcome.module').then(m => m.WelcomeModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
