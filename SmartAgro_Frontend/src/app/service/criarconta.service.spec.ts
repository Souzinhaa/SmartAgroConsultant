import { TestBed } from '@angular/core/testing';
import { CriarcontaService} from './criarconta.service'

describe('CriarcontaService', () => {
  let service: CriarcontaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CriarcontaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
