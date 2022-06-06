import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZoneamentoComponent } from './zoneamento.component';

describe('ZoneamentoComponent', () => {
  let component: ZoneamentoComponent;
  let fixture: ComponentFixture<ZoneamentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZoneamentoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZoneamentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
